using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacProject.Task2
{
    internal class MemoChecker
    {
        IQueryable<Memo> _memos;
        IMemoDueNotifier _notifier;

        public MemoChecker(IQueryable<Memo> memos, IMemoDueNotifier notifier)
        {
            _memos = memos;
            _notifier = notifier;
        }

        public void CheckNow()
        {
            var overDueMemos = _memos.Where(memo => memo.DueAt < DateTime.Now);
            foreach (var memo in overDueMemos)
                _notifier.MemoIsDue(memo);
        }
    }
}
