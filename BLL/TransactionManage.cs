
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class TransactionManage
    {
        public int InsertTransactionRecord(Transaction objTransaction)
        {
            return new TransactionService().InsertTransactionRecord(objTransaction);
        }

        public List<Transaction> GetTransactionList()
        {
            return new TransactionService().GetTransactionList();
        }

        public List<Transaction> GetUndoneTransactionList()
        {
            return new TransactionService().GetUndoneTransactionList();
        }

        public Transaction GetTransactionRecordByOrderNo(string orderNo)
        {
            return new TransactionService().GetTransactionRecordByOrderNo(orderNo);
        }

        public int UpdateTransactionRecord(Transaction objTransaction)
        {
            return new TransactionService().UpdateTransactionRecord(objTransaction);
        }

        public List<Transaction> GetTransactionListByName(string name)
        {
            return new TransactionService().GetTransactionListByName(name);
        }

        public List<Transaction> GetTransactionList(string name, int sortingType, DateTime dt)
        {
            return new TransactionService().GetTransactionList(name, sortingType, dt);
        }

        public int DeleteTransactionRecord(string orderNo)
        {
            return new TransactionService().DeleteTransactionRecordByOrderNo(orderNo);
        }

    }
}
