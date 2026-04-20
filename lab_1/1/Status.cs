/*
 * bool debt - есть ли задолженности
 * bool flur_old - просрочена ли флюр-я
 */
namespace ConsoleApp1
{
    internal class Status
    {
        private bool _debt;
        private bool _flurOld;

        public Status(bool debt, bool flurOld)
        {
            this._debt = debt;
            this._flurOld = flurOld;
        }

        public Status(Status obj)
        {
            this._debt = obj._debt;
            this._flurOld = obj._flurOld;
        }

        public Status()
        {
            this._debt = false;
            this._flurOld = false;
        }

        public bool Check()
        {
            return !(this._debt || this._flurOld);
        }

        public bool Debt
        {
            get
            {
                return _debt;
            }
            set
            {
                _debt = value;
            }
        }

        public bool FlurOld
        {
            get
            {
                return _flurOld;
            }
            set
            {
                _flurOld = value;
            }
        }

        public override string ToString()
        {
            return "Задолженности по учебе: " + (this._debt ? "Есть" : "Нет") +
                   "\nФлюрография просрочена: " + (this._flurOld ? "Да" : "Нет");
        }
    }
}