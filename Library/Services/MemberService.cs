
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class MemberService : IService
    {
        MemberRepository _memberRepository;
        LoanRepository _loanRepository;

        public event EventHandler Updated;

        protected virtual void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
            _loanRepository = repoFactory.GetLoanRepository();
        }

        //Gets all members
        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        //Adds a new member, who can now use the library
        public void AddMember(long ID, string name)
         {   
             Member mem = new Member() 
             { 
                 personalID = ID, 
                 Name = name
             };

            _memberRepository.Add(mem);
            OnUpdated(this, EventArgs.Empty);
        }

         //Removes a member, who can no longer use the library
         public void RemoveMember(Member mem)
            {   
                _memberRepository.Remove(mem);
                OnUpdated(this, EventArgs.Empty);
            }
    }
}
