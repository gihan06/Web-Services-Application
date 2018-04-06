Imports System.ServiceModel

<ServiceContract()>
Public Interface IWattsALoanService
    <OperationContract()>
    Function UpdateEmployee(ByVal EmployeeID As Integer, ByVal EmployeeNumber As String, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As String) As Boolean

    <OperationContract()>
    Function InsertCustomer(ByVal DateCreated As String, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean

    <OperationContract()>
    Function InsertEmployee(ByVal EmployeeNumber As String, ByVal BFirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As String) As Boolean

    <OperationContract()>
    Function InsertLoanAllocation(ByVal DatePrepared As String, ByVal EmployeeID As Integer, ByVal CustomerID As Integer, ByVal AccountNumber As String, ByVal LoanTypeID As Integer, ByVal LoanAmount As String, ByVal InterestRate As Decimal, ByVal Periods As Decimal) As Boolean

    <OperationContract()>
    Function SpecifyCurrentBalance(ByVal PmtDate As String, ByVal EmplID As String, ByVal LaID As String, PmtAmt As String) As Boolean

    <OperationContract()>
    Function UpdateCustomer(ByVal CustomerID As Integer, ByVal DateCreated As String, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean

    <OperationContract()>
    Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean

    <OperationContract()>
    Function InsertLoan(ByVal LoanType As String) As Boolean

End Interface

