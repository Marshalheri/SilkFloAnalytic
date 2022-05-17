using SilkFloAnalytic.Data;
using SilkFloAnalytic.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SilkFloAnalytic.Stores.UserStore
{
    public class ComplaintStore
    {
        private readonly IDataService _dataService;
        private IEnumerable<Complaint> _complaints;
        public ComplaintStore(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<IEnumerable<Complaint>> GetComplaints()
        {
            return _complaints;
        }

        public async Task FetchComplaintsAsync()
        {
            this._complaints = await _dataService.GetComplaints();
            BroadcastStateChange();
        }


        #region observer pattern
        //////////////////////////
        ///

        private Action _listeners;

        public void AddStateChangeListener(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListener(Action listener)
        {
            _listeners -= listener;
        }

        private void BroadcastStateChange()
        {
            _listeners.Invoke();
        }
        #endregion
    }
}
