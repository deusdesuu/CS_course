using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class VisitStat
    {
        private int _id;
        private string _pageUrl;
        private DateTime _visitTime;
        private int _duration;
        private bool _isRegistered;

        public VisitStat()
        {
            this._id = -1;
            this._pageUrl = "";
            this._visitTime = DateTime.Now;
            this._duration = -1;
            this._isRegistered = false;
        }
        public VisitStat(int id, string pageUrl, DateTime visitTime, int duration, bool isRegistered)
        {
            this._id = id;
            this._pageUrl = pageUrl;
            this._visitTime = visitTime;
            this._duration = duration;
            this._isRegistered = isRegistered;
        }

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string PageUrl
        {
            get
            {
                return this._pageUrl;
            }
            set
            {
                this._pageUrl= value;
            }
        }
        public DateTime VisitTime
        {
            get
            {
                return this._visitTime;
            }
            set
            {
                this._visitTime = value;
            }
        }
        public int Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }
        public bool IsRegistered
        {
            get
            {
                return this._isRegistered;
            }
            set
            {
                this._isRegistered = value;
            }
        }

        public override string ToString()
        {
            return $"[{Id}]\t {VisitTime:G}\t | {PageUrl}\t | Время: {Duration}с\t | Рег: {(IsRegistered ? "Да" : "Нет")}";
        }
        public static bool IsUrl(string str)
        {
            return str.StartsWith("/");
        }
    }
}
