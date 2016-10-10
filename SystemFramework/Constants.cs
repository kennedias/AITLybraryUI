/* Constants of the application
 * 
 * Project: Assignment 2 - AIT
 * Developer: Kennedy Oliveira - ID 5399
 * Data of release: 07/09/2016
 * Version: 1.0 - Release
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemFramework
{
    /// <summary>
    /// Constants of the application.
    /// </summary>
    public static class Constants
    {
        #region GerenalValues
        public const string userDescription = "User";
        public const string supervisorDescription = "Supervisor";
        public const string administratorDescription = "Administrator";
        public const int userCode = 1;
        public const int supervisorCode = 2;
        public const int administratorCode = 3;
        public const decimal lateFeeToInsert = 0;
        public const string actualDateReturnForInsert = "2001-01-01";
        public const int daysOfBorrowingBook = 7;
        public const decimal lateFeePerDay = 2;
        public const string userLevel = "Administrator,Supervisor,User";
        public static readonly string[] userLevelList = userLevel.Split(',');
        public static string userPasswordDefault = "aitLybrary1";
        public static int numberZero = 0;
        public static int minYearOfBook = 1900;
        #endregion

        #region SystemsMessages
        public const string msgErrorBusinessToUser = "This action can not be completed! ";
        public const string msgErrorSystemToUser = "Sorry, something went wrong! Please contact the system support team.";
        public const string msgNoSearchCriteria = "No search criteria was informed.";
        public const string msgNoMatchesFound = "No matches found.";
        public const string msgLabelDefault = "[...]";
        public const string msgUserNameBlank = "User Name is blank.";
        public const string msgNoRecordUpdated = "No record were updated!";
        public const string msgNoRecordDeleted = "No record were deleted!";
        public const string msgNoRecordInserted = "No record were inserted!";
        public const string msgOperationCompleted = "Operation completed with success!";
        public const string msgSelectRecord = "Please, select a record first.";
        public const string msgValidInformation = "Please, inform a valid information.";
        public const string msgNameDescriptionInUse = "Name/Description already in use. Change a new one";
        public const string msgInvalidNameDescription = "Invalid Name/Description. ";
        public const string msgInvalidUserCode = "Invalid user level code for the code. ";
        public const string msgExceptionRegisterInUse = "Register is in use and can not be deleted.";
        public const string msgExceptionISBNInUse = "This ISBN is already in use.";
        #endregion

        #region DataFiels
        public const string fieldID = "ID";
        public const string fieldLevelCode = "LevelCode";
        public const string fieldLevelDescription = "LevelDescription";
        public const string fieldUserId = "UserId";
        public const string fieldBorrowId= "BorrowId";
        public const string fieldLatefee = "Latefee";
        public const string fieldUser = "User";
        public const string fieldReserveId = "ReserveId";
        #endregion

        #region FaultSourceWS
        public const string faultAplicationError = "AplicationError";
        public const string faultBusinessError = "BusinessError";
        public const string faultUri = "http://tempuri.org/CategoriesService";
        #endregion

   }
}
