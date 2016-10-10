using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemFramework
{
    public static class AppEnum
    {
        public enum ViewBookModel
        {
            Isbn,
            BookName,
            Publisher,
            PublishYear,
            Pages,
            Author,
            Category,
            Language
        }

        public enum ViewBookReservedModel
        {
            Isbn,
            Name,
            Author,
            User,
            ReserveDate,
            ReserveId,
            UserId

        }

        public enum TabUserModel
        {
            ID,
            Name,
            LevelCode,
            LevelDescription
        }


        public enum ViewBookBorrowedWithUserModel
        {
            ISBN,
            Name,
            Author,
            User,
            Borrow,
            Return,
            LateFee,
            UserId,
            BorrowId
        }

        public enum TabMasterModel
        {
            ID,
            Description
        }

        public enum FaultSourceWS
        {
            AplicationError = 0,
            BusinessError = 1
        }
    }
}
