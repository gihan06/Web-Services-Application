Imports System.Data.SqlClient
Imports System.Data

Public Class Service

    Implements IWattsALoanService

    Function UpdateEmployee(ByVal EmployeeID As Integer, ByVal EmployeeNumber As String, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As String) As Boolean Implements IWattsALoanService.UpdateEmployee


        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("UpdateEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = EmployeeID

        Dim objParameter2 As New SqlParameter("@EmployeeNumber", SqlDbType.NChar, 10)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = EmployeeNumber

        Dim objParameter3 As New SqlParameter("@FirstName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = FirstName

        Dim objParameter4 As New SqlParameter("@LastName", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = LastName

        Dim objParameter5 As New SqlParameter("@Title", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = Title

        Dim objParameter6 As New SqlParameter("@HourlySalary", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = HourlySalary

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

    Function InsertCustomer(ByVal DateCreated As String, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean Implements IWattsALoanService.InsertCustomer

        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@DateCreated", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = DateCreated

        Dim objParameter2 As New SqlParameter("@FullName", SqlDbType.NChar, 50)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = FullName

        Dim objParameter3 As New SqlParameter("@BillingAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = BillingAddress

        Dim objParameter4 As New SqlParameter("@BillingCity", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = BillingCity

        Dim objParameter5 As New SqlParameter("@BillingState", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = BillingState

        Dim objParameter6 As New SqlParameter("@BillingZIPCide", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = BillingZIPCide

        Dim objParameter7 As New SqlParameter("@EmailAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = EmailAddress

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function


    Function InsertEmployee(ByVal EmployeeNumber As String, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As String) As Boolean Implements IWattsALoanService.InsertEmployee

        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeNumber", SqlDbType.NChar, 10)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = FirstName

        Dim objParameter2 As New SqlParameter("@FirstName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = FirstName

        Dim objParameter3 As New SqlParameter("@LastName", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = LastName

        Dim objParameter4 As New SqlParameter("@Title", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = Title

        Dim objParameter5 As New SqlParameter("@HourlySalary", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = HourlySalary

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

    Function InsertLoanAllocation(ByVal DatePrepared As String, ByVal EmployeeID As Integer, ByVal CustomerID As Integer, ByVal AccountNumber As String, ByVal LoanTypeID As Integer, ByVal LoanAmount As String, ByVal InterestRate As Decimal, ByVal Periods As Decimal) As Boolean Implements IWattsALoanService.InsertLoanAllocation



        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertLoanAllocation", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@DatePrepared", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = DatePrepared

        Dim objParameter2 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = EmployeeID

        Dim objParameter3 As New SqlParameter("@CustomerID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = CustomerID

        Dim objParameter4 As New SqlParameter("@AccountNumber", SqlDbType.NChar, 10)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = AccountNumber

        Dim objParameter5 As New SqlParameter("@LoanTypeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = LoanTypeID

        Dim objParameter6 As New SqlParameter("@LoanAmount", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = LoanAmount

        Dim objParameter7 As New SqlParameter("@InterestRate", SqlDbType.Decimal, 6, 2)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = InterestRate

        Dim objParameter8 As New SqlParameter("@Periods", SqlDbType.Decimal, 6, 2)
        objCommand.Parameters.Add(objParameter8)
        objParameter8.Direction = ParameterDirection.Input
        objParameter8.Value = Periods

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function


    Function SpecifyCurrentBalance(ByVal PmtDate As String, ByVal EmplID As String, ByVal LaID As String, ByVal PmtAmt As String) As Boolean Implements IWattsALoanService.SpecifyCurrentBalance


        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("SpecifyCurrentBalance", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@PmtDate", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = PmtDate

        Dim objParameter2 As New SqlParameter("@EmplID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = EmplID

        Dim objParameter3 As New SqlParameter("@LaID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = LaID

        Dim objParameter4 As New SqlParameter("@PmtAmt", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = PmtAmt

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

    Function UpdateCustomer(ByVal CustomerID As Integer, ByVal DateCreated As String, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean Implements IWattsALoanService.UpdateCustomer


        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("UpdateCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@CustomerID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = CustomerID

        Dim objParameter2 As New SqlParameter("@DateCreated", SqlDbType.DateTime2, 7)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = DateCreated

        Dim objParameter3 As New SqlParameter("@FullName", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = FullName

        Dim objParameter8 As New SqlParameter("@BillingAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter8)
        objParameter8.Direction = ParameterDirection.Input
        objParameter8.Value = BillingAddress

        Dim objParameter4 As New SqlParameter("@BillingCity", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = BillingCity

        Dim objParameter5 As New SqlParameter("@BillingState", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = BillingState

        Dim objParameter6 As New SqlParameter("@BillingZIPCide", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = BillingZIPCide

        Dim objParameter7 As New SqlParameter("@EmailAddress", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = EmailAddress

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

    Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean Implements IWattsALoanService.DeleteEmployee


        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("DeleteEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = EmployeeID

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

    Function InsertLoan(ByVal LoanType As String) As Boolean Implements IWattsALoanService.InsertLoan


        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        objConnection = New SqlConnection("Data Source=PE205-12;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertLoan", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@LoanType", SqlDbType.NVarChar, 50)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = LoanType

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False

    End Function

End Class

