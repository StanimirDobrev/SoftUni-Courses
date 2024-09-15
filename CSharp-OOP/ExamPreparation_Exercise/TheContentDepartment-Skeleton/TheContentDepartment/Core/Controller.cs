using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Core.Contracts;
using TheContentDepartment.Models;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Repositories;
using TheContentDepartment.Utilities.Messages;

namespace TheContentDepartment.Core
{
    public class Controller : IController
    {
        private readonly ResourceRepository _resources = new ResourceRepository();
        private readonly MemberRepository _members = new MemberRepository();
        public string JoinTeam(string memberType, string memberName, string path)
        {
            ITeamMember member;
            //switch (memberType)
            //{
            //    case nameof(TeamLead):
            //        member = new TeamLead(memberName, path);
            //        break;
            //    case nameof(ContentMember):
            //        member = new TeamLead(memberName, path);
            //        break;
            //    default:
            //        string.Format(OutputMessages.MemberTypeInvalid, memberType);
            //        break;
            //}
            if (memberType == nameof(TeamLead)) member = new TeamLead(memberName, path);
            else if (memberType == nameof(ContentMember)) member = new ContentMember(memberName, path);
            else return string.Format(OutputMessages.MemberTypeInvalid, memberType);


            if (_members.Models.Any(m => m.Path == path))
            {
                return string.Format(OutputMessages.PositionOccupied);
            }

            if (_members.Models.Any(m => m.Name == memberName))
            {
                return string.Format(OutputMessages.MemberExists, memberName);
            }

            this._members.Add(member);
            return string.Format(OutputMessages.MemberJoinedSuccessfully, memberName);
        }


        public string CreateResource(string resourceType, string resourceName, string path)
        {
            var creator = _members.Models.FirstOrDefault(m => m.Path == path);
            if (creator is null)
            {
                return string.Format(OutputMessages.NoContentMemberAvailable, resourceName);
            }
            else if (creator is not null)
            {
                return string.Format(OutputMessages.ResourceExists, resourceName);
            }

            IResource resource = null;
            switch (resourceType)
            {
                case nameof(Exam):
                    resource = new Exam(resourceName, creator.Name);
                    break;
                case nameof(Workshop):
                    resource = new Workshop(resourceName, creator.Name);
                    break;
                case nameof(Presentation):
                    resource = new Presentation(resourceName, creator.Name);
                    break;
                default:
                    string.Format(OutputMessages.ResourceTypeInvalid, resourceType);
                    break;
            }

            _resources.Add(resource);
            creator.WorkOnTask(resource.Name);
            return string.Format(OutputMessages.ResourceCreatedSuccessfully, creator.Name, resourceType, resourceName);
        }


        public string LogTesting(string memberName)
        {
            var member = _members.TakeOne(memberName);
            if (member is null)
            {
                return string.Format(OutputMessages.WrongMemberName);
            }

            var resource = _resources.Models.Where(m => !m.IsTested && m.Creator == memberName).MinBy(m => m.Priority);
            if (resource is null)
            {
                return string.Format(OutputMessages.NoResourcesForMember, memberName);
            }

            var teamLead = _resources.Models.First(x => x is TeamLead);

            member.FinishTask(resource.Name);
            member.WorkOnTask(resource.Name);
            resource.Test();
            return string.Format(OutputMessages.ResourceTested, resource.Name);
        }


        //public string ApproveResource(string resourceName, bool isApprovedByTeamLead)
        //{
        //    var resource = _resources.TakeOne(resourceName);
        //    if (!resource.IsTested) return string.Format(OutputMessages.ResourceNotTested, resourceName);

        //    var teamLead = _members.Models.First(x => x is TeamLead);

        //    if (isApprovedByTeamLead)
        //    {
        //        resource.Approve();
        //        teamLead.FinishTask(resourceName);
        //        return string.Format(OutputMessages.ResourceApproved, teamLead.Name, resourceName);
        //    }
        //    else
        //    {
        //        resource.Test();
        //        return string.Format(OutputMessages.ResourceReturned, teamLead.Name, resourceName);
        //    }
        //}
        public string ApproveResource(string resourceName, bool isApprovedByTeamLead)
        {
            var resource = this._resources.TakeOne(resourceName);
            if (!resource.IsTested) return string.Format(OutputMessages.ResourceNotTested, resourceName);

            var teamLead = this._members.Models.First(x => x is TeamLead);

            if (isApprovedByTeamLead)
            {
                resource.Approve();
                teamLead.FinishTask(resourceName);
                return string.Format(OutputMessages.ResourceApproved, teamLead.Name, resourceName);
            }
            else
            {
                resource.Test();
                return string.Format(OutputMessages.ResourceReturned, teamLead.Name, resourceName);
            }
        }

        public string DepartmentReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Finished Tasks:");

            foreach (var resource in _resources.Models.Where(m => m.IsApproved))
            {
                sb.AppendLine();
                sb.Append("--");
                sb.Append(resource);
            }

            sb.AppendLine();
            sb.Append("Team Report:");

            var teamLead = _members.Models.Single(m => m is TeamLead);
            sb.Append("--");
            sb.Append(teamLead);

            foreach (var teamMember in _members.Models)
            {
                if (teamMember == teamLead)
                {
                    continue;
                }

                sb.AppendLine();
                sb.Append(teamMember);
            }
            return sb.ToString();
        }

    }
}
