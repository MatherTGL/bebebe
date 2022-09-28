using DataMoneyControl;
using UnityEngine;
using UnityEngine.Assertions;

namespace Bank
{
    public sealed class BankControl : IBank
    {
        private IMoneyControl _IMoneyControl;


        void IBank.Initialization(in IMoneyControl moneyControl)
        {
            Assert.IsNotNull(moneyControl);
            Debug.Log("Initialization Bank");
            Debug.Log(moneyControl);
    
            _IMoneyControl = moneyControl;
            Debug.Log(_IMoneyControl);
            //Подгрузка сейвов и прочее-прочее
        }

        void IBank.TakeLoan(in double amountBorrowedMoney)
        {
            Debug.Log("Take Loan");
            Debug.Log(_IMoneyControl);
             
            _IMoneyControl.AddMoney(amountBorrowedMoney);
        }

        void IBank.RepayLoan(in double amountMoneyDiscarded)
        {
            Debug.Log("Repay Loan");
            _IMoneyControl.ReduceMoney(amountMoneyDiscarded);
        }
    }
}