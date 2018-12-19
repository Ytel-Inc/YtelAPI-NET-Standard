# Getting started

Ytel API version 3.1.2

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (YtelAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the YtelAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

### 3. Add reference of the library project

In order to use the YtelAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` YtelAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```YtelAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Ytel%20API-CSharp&workspaceName=YtelAPI&projectName=YtelAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

YtelAPIClient client = new YtelAPIClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [UsageController](#usage_controller)
* [SubAccountController](#sub_account_controller)
* [AccountController](#account_controller)
* [EmailController](#email_controller)
* [RecordingController](#recording_controller)
* [TranscriptionController](#transcription_controller)
* [ConferenceController](#conference_controller)
* [PhoneNumberController](#phone_number_controller)
* [CarrierController](#carrier_controller)
* [DedicatedShortCodeController](#dedicated_short_code_controller)
* [SharedShortCodeController](#shared_short_code_controller)
* [SMSController](#sms_controller)
* [VoiceController](#voice_controller)

## <a name="usage_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.UsageController") UsageController

### Get singleton instance

The singleton instance of the ``` UsageController ``` class can be accessed from the API Client.

```csharp
UsageController usage = client.Usage;
```

### <a name="create_list_usage"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.UsageController.CreateListUsage") CreateListUsage

> Retrieve usage metrics regarding your Ytel account. The results includes inbound/outbound voice calls and inbound/outbound SMS messages as well as carrier lookup requests.


```csharp
Task<string> CreateListUsage(
        Standard.Models.ProductCodeEnum? productCode = null,
        string startDate = null,
        string endDate = null,
        string includeSubAccounts = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| productCode |  ``` Optional ```  | Filter usage results by product type. |
| startDate |  ``` Optional ```  | Filter usage objects by start date. |
| endDate |  ``` Optional ```  | Filter usage objects by end date. |
| includeSubAccounts |  ``` Optional ```  | Will include all subaccount usage data |


#### Example Usage

```csharp
var productCode = (Standard.Models.ProductCodeEnum?)0;
string startDate = "startDate";
string endDate = "endDate";
string includeSubAccounts = "IncludeSubAccounts";

string result = await usage.CreateListUsage(productCode, startDate, endDate, includeSubAccounts);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sub_account_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.SubAccountController") SubAccountController

### Get singleton instance

The singleton instance of the ``` SubAccountController ``` class can be accessed from the API Client.

```csharp
SubAccountController subAccount = client.SubAccount;
```

### <a name="create_subaccount"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SubAccountController.CreateSubaccount") CreateSubaccount

> Create a sub user account under the parent account


```csharp
Task<string> CreateSubaccount(
        string firstName,
        string lastName,
        string email,
        string friendlyName,
        string password)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| firstName |  ``` Required ```  | Sub account user first name |
| lastName |  ``` Required ```  | sub account user last name |
| email |  ``` Required ```  | Sub account email address |
| friendlyName |  ``` Required ```  | Descriptive name of the sub account |
| password |  ``` Required ```  | The password of the sub account.  Please make sure to make as password that is at least 8 characters long, contain a symbol, uppercase and a number. |


#### Example Usage

```csharp
string firstName = "FirstName";
string lastName = "LastName";
string email = "Email";
string friendlyName = "FriendlyName";
string password = "Password";

string result = await subAccount.CreateSubaccount(firstName, lastName, email, friendlyName, password);

```


### <a name="create_delete_subaccount"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SubAccountController.CreateDeleteSubaccount") CreateDeleteSubaccount

> Delete sub account or merge numbers into parent


```csharp
Task<string> CreateDeleteSubaccount(string subAccountSID, Standard.Models.MergeNumberEnum mergeNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be deleted |
| mergeNumber |  ``` Required ```  | 0 to delete or 1 to merge numbers to parent account. |


#### Example Usage

```csharp
string subAccountSID = "SubAccountSID";
var mergeNumber = (Standard.Models.MergeNumberEnum)0;

string result = await subAccount.CreateDeleteSubaccount(subAccountSID, mergeNumber);

```


### <a name="create_toggle_subaccount_status"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SubAccountController.CreateToggleSubaccountStatus") CreateToggleSubaccountStatus

> Suspend or unsuspend


```csharp
Task<string> CreateToggleSubaccountStatus(string subAccountSID, Standard.Models.ActivateEnum activate)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be activated or suspended |
| activate |  ``` Required ```  | 0 to suspend or 1 to activate |


#### Example Usage

```csharp
string subAccountSID = "SubAccountSID";
var activate = (Standard.Models.ActivateEnum)1;

string result = await subAccount.CreateToggleSubaccountStatus(subAccountSID, activate);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="account_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.AccountController") AccountController

### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

### <a name="create_view_account"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.AccountController.CreateViewAccount") CreateViewAccount

> Retrieve information regarding your Ytel account by a specific date. The response object will contain data such as account status, balance, and account usage totals.


```csharp
Task<string> CreateViewAccount(string date)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Required ```  | Filter account information based on date. |


#### Example Usage

```csharp
string date = "Date";

string result = await account.CreateViewAccount(date);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="email_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.EmailController") EmailController

### Get singleton instance

The singleton instance of the ``` EmailController ``` class can be accessed from the API Client.

```csharp
EmailController email = client.Email;
```

### <a name="create_blocked_emails"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateBlockedEmails") CreateBlockedEmails

> Retrieve a list of emails that have been blocked.


```csharp
Task<string> CreateBlockedEmails(string offset = null, string limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of blocked emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
string offset = "Offset";
string limit = "Limit";

string result = await email.CreateBlockedEmails(offset, limit);

```


### <a name="create_remove_invalid_email"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateRemoveInvalidEmail") CreateRemoveInvalidEmail

> Remove an email from the invalid email list.


```csharp
Task<string> CreateRemoveInvalidEmail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the invalid email list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateRemoveInvalidEmail(email);

```


### <a name="create_invalid_emails"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateInvalidEmails") CreateInvalidEmails

> Retrieve a list of invalid email addresses.


```csharp
Task<string> CreateInvalidEmails(string offset = null, string limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of invalid emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
string offset = "Offset";
string limit = "Limit";

string result = await email.CreateInvalidEmails(offset, limit);

```


### <a name="create_remove_bounced_email"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateRemoveBouncedEmail") CreateRemoveBouncedEmail

> Remove an email address from the bounced list.


```csharp
Task<string> CreateRemoveBouncedEmail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address to be remove from the bounced email list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateRemoveBouncedEmail(email);

```


### <a name="create_bounced_emails"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateBouncedEmails") CreateBouncedEmails

> Retrieve a list of emails that have bounced.


```csharp
Task<string> CreateBouncedEmails(string offset = null, string limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of bounced emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
string offset = "Offset";
string limit = "Limit";

string result = await email.CreateBouncedEmails(offset, limit);

```


### <a name="create_spam_emails"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateSpamEmails") CreateSpamEmails

> Retrieve a list of emails that are on the spam list.


```csharp
Task<string> CreateSpamEmails(string offset = null, string limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of spam emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
string offset = "Offset";
string limit = "Limit";

string result = await email.CreateSpamEmails(offset, limit);

```


### <a name="create_send_email"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateSendEmail") CreateSendEmail

> Create and submit an email message to one or more email addresses.


```csharp
Task<string> CreateSendEmail(
        string to,
        Standard.Models.TypeEnum type,
        string subject,
        string message,
        string mfrom = null,
        string cc = null,
        string bcc = null,
        string attachment = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| type |  ``` Required ```  | Specifies the type of email to be sent |
| subject |  ``` Required ```  | The subject of the mail. Must be a valid string. |
| message |  ``` Required ```  | The email message that is to be sent in the text. |
| mfrom |  ``` Optional ```  | A valid address that will send the email. |
| cc |  ``` Optional ```  | Carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| bcc |  ``` Optional ```  | Blind carbon copy. A valid address that will receive the email. Multiple addresses can be separated by using commas. |
| attachment |  ``` Optional ```  | A file that is attached to the email. Must be less than 7 MB in size. |


#### Example Usage

```csharp
string to = "To";
var type = Standard.Models.TypeEnumHelper.ParseString("text");
string subject = "Subject";
string message = "Message";
string mfrom = "From";
string cc = "Cc";
string bcc = "Bcc";
string attachment = "Attachment";

string result = await email.CreateSendEmail(to, type, subject, message, mfrom, cc, bcc, attachment);

```


### <a name="create_remove_blocked_address"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateRemoveBlockedAddress") CreateRemoveBlockedAddress

> Remove an email from blocked emails list.


```csharp
Task<string> CreateRemoveBlockedAddress(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address to be remove from the blocked list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateRemoveBlockedAddress(email);

```


### <a name="add_email_unsubscribe"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.AddEmailUnsubscribe") AddEmailUnsubscribe

> Add an email to the unsubscribe list


```csharp
Task<string> AddEmailUnsubscribe(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be added to the unsubscribe list |


#### Example Usage

```csharp
string email = "email";

string result = await email.AddEmailUnsubscribe(email);

```


### <a name="create_remove_unsubscribed_email"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateRemoveUnsubscribedEmail") CreateRemoveUnsubscribedEmail

> Remove an email address from the list of unsubscribed emails.


```csharp
Task<string> CreateRemoveUnsubscribedEmail(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the unsubscribe list. |


#### Example Usage

```csharp
string email = "email";

string result = await email.CreateRemoveUnsubscribedEmail(email);

```


### <a name="create_list_unsubscribed_emails"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateListUnsubscribedEmails") CreateListUnsubscribedEmails

> Retrieve a list of email addresses from the unsubscribe list.


```csharp
Task<string> CreateListUnsubscribedEmails(string offset = null, string limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | The starting point of the list of unsubscribed emails that should be returned. |
| limit |  ``` Optional ```  | The count of results that should be returned. |


#### Example Usage

```csharp
string offset = "Offset";
string limit = "Limit";

string result = await email.CreateListUnsubscribedEmails(offset, limit);

```


### <a name="create_remove_spam_address"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.EmailController.CreateRemoveSpamAddress") CreateRemoveSpamAddress

> Remove an email from the spam email list.


```csharp
Task<string> CreateRemoveSpamAddress(string email)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | A valid email address that is to be remove from the spam list. |


#### Example Usage

```csharp
string email = "Email";

string result = await email.CreateRemoveSpamAddress(email);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="recording_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.RecordingController") RecordingController

### Get singleton instance

The singleton instance of the ``` RecordingController ``` class can be accessed from the API Client.

```csharp
RecordingController recording = client.Recording;
```

### <a name="create_delete_recording"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.RecordingController.CreateDeleteRecording") CreateDeleteRecording

> Remove a recording from your Ytel account.


```csharp
Task<string> CreateDeleteRecording(string recordingsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingsid |  ``` Required ```  | The unique identifier for a recording. |


#### Example Usage

```csharp
string recordingsid = "recordingsid";

string result = await recording.CreateDeleteRecording(recordingsid);

```


### <a name="create_list_recordings"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.RecordingController.CreateListRecordings") CreateListRecordings

> Retrieve a list of recording objects.


```csharp
Task<string> CreateListRecordings(
        int? page = null,
        int? pagesize = null,
        string datecreated = null,
        string callsid = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |
| datecreated |  ``` Optional ```  | Filter results by creation date |
| callsid |  ``` Optional ```  | The unique identifier for a call. |


#### Example Usage

```csharp
int? page = 118;
int? pagesize = 118;
string datecreated = "Datecreated";
string callsid = "callsid";

string result = await recording.CreateListRecordings(page, pagesize, datecreated, callsid);

```


### <a name="create_view_recording"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.RecordingController.CreateViewRecording") CreateViewRecording

> Retrieve the recording of a call by its RecordingSid. This resource will return information regarding the call such as start time, end time, duration, and so forth.


```csharp
Task<string> CreateViewRecording(string recordingsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingsid |  ``` Required ```  | The unique identifier for the recording. |


#### Example Usage

```csharp
string recordingsid = "recordingsid";

string result = await recording.CreateViewRecording(recordingsid);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="transcription_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.TranscriptionController") TranscriptionController

### Get singleton instance

The singleton instance of the ``` TranscriptionController ``` class can be accessed from the API Client.

```csharp
TranscriptionController transcription = client.Transcription;
```

### <a name="create_transcribe_audio_url"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.TranscriptionController.CreateTranscribeAudioURL") CreateTranscribeAudioURL

> Transcribe an audio recording from a file.


```csharp
Task<string> CreateTranscribeAudioURL(string audiourl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| audiourl |  ``` Required ```  | URL pointing to the location of the audio file that is to be transcribed. |


#### Example Usage

```csharp
string audiourl = "audiourl";

string result = await transcription.CreateTranscribeAudioURL(audiourl);

```


### <a name="create_list_transcriptions"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.TranscriptionController.CreateListTranscriptions") CreateListTranscriptions

> Retrieve a list of transcription objects for your Ytel account.


```csharp
Task<string> CreateListTranscriptions(
        int? page = null,
        int? pagesize = null,
        Standard.Models.StatusEnum? status = null,
        string dateTranscribed = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |
| status |  ``` Optional ```  | The state of the transcription. |
| dateTranscribed |  ``` Optional ```  | The date the transcription took place. |


#### Example Usage

```csharp
int? page = 118;
int? pagesize = 118;
var status = Standard.Models.StatusEnum?Helper.ParseString("inprogress");
string dateTranscribed = "dateTranscribed";

string result = await transcription.CreateListTranscriptions(page, pagesize, status, dateTranscribed);

```


### <a name="create_view_transcription"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.TranscriptionController.CreateViewTranscription") CreateViewTranscription

> Retrieve information about a transaction by its TranscriptionSid.


```csharp
Task<string> CreateViewTranscription(string transcriptionsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transcriptionsid |  ``` Required ```  | The unique identifier for a transcription object. |


#### Example Usage

```csharp
string transcriptionsid = "transcriptionsid";

string result = await transcription.CreateViewTranscription(transcriptionsid);

```


### <a name="create_transcribe_recording"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.TranscriptionController.CreateTranscribeRecording") CreateTranscribeRecording

> Transcribe a recording by its RecordingSid.


```csharp
Task<string> CreateTranscribeRecording(string recordingSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | The unique identifier for a recording object. |


#### Example Usage

```csharp
string recordingSid = "recordingSid";

string result = await transcription.CreateTranscribeRecording(recordingSid);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="conference_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.ConferenceController") ConferenceController

### Get singleton instance

The singleton instance of the ``` ConferenceController ``` class can be accessed from the API Client.

```csharp
ConferenceController conference = client.Conference;
```

### <a name="create_list_conferences"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateListConferences") CreateListConferences

> Retrieve a list of conference objects.


```csharp
Task<string> CreateListConferences(
        int? page = null,
        int? pagesize = null,
        string friendlyName = null,
        string dateCreated = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| friendlyName |  ``` Optional ```  | Only return conferences with the specified FriendlyName |
| dateCreated |  ``` Optional ```  | Conference created date |


#### Example Usage

```csharp
int? page = 118;
int? pagesize = 118;
string friendlyName = "FriendlyName";
string dateCreated = "DateCreated";

string result = await conference.CreateListConferences(page, pagesize, friendlyName, dateCreated);

```


### <a name="create_hangup_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateHangupParticipant") CreateHangupParticipant

> Remove a participant from a conference.


```csharp
Task<string> CreateHangupParticipant(string participantSid, string conferenceSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |


#### Example Usage

```csharp
string participantSid = "ParticipantSid";
string conferenceSid = "ConferenceSid";

string result = await conference.CreateHangupParticipant(participantSid, conferenceSid);

```


### <a name="create_play_audio"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreatePlayAudio") CreatePlayAudio

> Play an audio file during a conference.


```csharp
Task<string> CreatePlayAudio(string conferenceSid, string participantSid, Standard.Models.AudioUrlEnum audioUrl)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |
| audioUrl |  ``` Required ```  | The URL for the audio file that is to be played during the conference. Multiple audio files can be chained by using a semicolon. |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";
string participantSid = "ParticipantSid";
var audioUrl = Standard.Models.AudioUrlEnumHelper.ParseString("mp3");

string result = await conference.CreatePlayAudio(conferenceSid, participantSid, audioUrl);

```


### <a name="create_list_participants"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateListParticipants") CreateListParticipants

> Retrieve a list of participants for an in-progress conference.


```csharp
Task<string> CreateListParticipants(
        string conferenceSid,
        int? page = null,
        int? pagesize = null,
        bool? muted = null,
        bool? deaf = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference. |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |
| muted |  ``` Optional ```  | Specifies if participant should be muted. |
| deaf |  ``` Optional ```  | Specifies if the participant should hear audio in the conference. |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";
int? page = 118;
int? pagesize = 118;
bool? muted = false;
bool? deaf = false;

string result = await conference.CreateListParticipants(conferenceSid, page, pagesize, muted, deaf);

```


### <a name="create_conference"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateConference") CreateConference

> Here you can experiment with initiating a conference call through Ytel and view the request response generated when doing so.


```csharp
Task<string> CreateConference(
        string url,
        string mfrom,
        string to,
        string method = null,
        string statusCallBackUrl = null,
        string statusCallBackMethod = null,
        string fallbackUrl = null,
        string fallbackMethod = null,
        bool? record = null,
        string recordCallBackUrl = null,
        string recordCallBackMethod = null,
        string scheduleTime = null,
        int? timeout = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| url |  ``` Required ```  | URL requested once the conference connects |
| mfrom |  ``` Required ```  | A valid 10-digit number (E.164 format) that will be initiating the conference call. |
| to |  ``` Required ```  | A valid 10-digit number (E.164 format) that is to receive the conference call. |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the conference is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallbackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| record |  ``` Optional ```  | Specifies if the conference should be recorded. |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion. |
| recordCallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once conference connects. |
| scheduleTime |  ``` Optional ```  | Schedule conference in future. Schedule time must be greater than current time |
| timeout |  ``` Optional ```  | The number of seconds the call stays on the line while waiting for an answer. The max time limit is 999 and the default limit is 60 seconds but lower times can be set. |


#### Example Usage

```csharp
string url = "Url";
string mfrom = "From";
string to = "To";
string method = "Method";
string statusCallBackUrl = "StatusCallBackUrl";
string statusCallBackMethod = "StatusCallBackMethod";
string fallbackUrl = "FallbackUrl";
string fallbackMethod = "FallbackMethod";
bool? record = false;
string recordCallBackUrl = "RecordCallBackUrl";
string recordCallBackMethod = "RecordCallBackMethod";
string scheduleTime = "ScheduleTime";
int? timeout = 118;

string result = await conference.CreateConference(url, mfrom, to, method, statusCallBackUrl, statusCallBackMethod, fallbackUrl, fallbackMethod, record, recordCallBackUrl, recordCallBackMethod, scheduleTime, timeout);

```


### <a name="create_view_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateViewParticipant") CreateViewParticipant

> Retrieve information about a participant by its ParticipantSid.


```csharp
Task<string> CreateViewParticipant(string conferenceSid, string participantSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantSid |  ``` Required ```  | The unique identifier for a participant object. |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";
string participantSid = "ParticipantSid";

string result = await conference.CreateViewParticipant(conferenceSid, participantSid);

```


### <a name="create_view_conference"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateViewConference") CreateViewConference

> Retrieve information about a conference by its ConferenceSid.


```csharp
Task<string> CreateViewConference(string conferenceSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier of each conference resource |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";

string result = await conference.CreateViewConference(conferenceSid);

```


### <a name="add_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.AddParticipant") AddParticipant

> Add Participant in conference 


```csharp
Task<string> AddParticipant(
        string conferenceSid,
        string participantNumber,
        bool? muted = null,
        bool? deaf = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | The unique identifier for a conference object. |
| participantNumber |  ``` Required ```  | The phone number of the participant to be added. |
| muted |  ``` Optional ```  | Specifies if participant should be muted. |
| deaf |  ``` Optional ```  | Specifies if the participant should hear audio in the conference. |


#### Example Usage

```csharp
string conferenceSid = "ConferenceSid";
string participantNumber = "ParticipantNumber";
bool? muted = false;
bool? deaf = false;

string result = await conference.AddParticipant(conferenceSid, participantNumber, muted, deaf);

```


### <a name="create_silence_participant"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.ConferenceController.CreateSilenceParticipant") CreateSilenceParticipant

> Deaf Mute Participant


```csharp
Task<string> CreateSilenceParticipant(
        string conferenceSid,
        string participantSid,
        bool? muted = null,
        bool? deaf = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | ID of the active conference |
| participantSid |  ``` Required ```  | ID of an active participant |
| muted |  ``` Optional ```  | Mute a participant |
| deaf |  ``` Optional ```  | Make it so a participant cant hear |


#### Example Usage

```csharp
string conferenceSid = "conferenceSid";
string participantSid = "ParticipantSid";
bool? muted = false;
bool? deaf = false;

string result = await conference.CreateSilenceParticipant(conferenceSid, participantSid, muted, deaf);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="phone_number_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.PhoneNumberController") PhoneNumberController

### Get singleton instance

The singleton instance of the ``` PhoneNumberController ``` class can be accessed from the API Client.

```csharp
PhoneNumberController phoneNumber = client.PhoneNumber;
```

### <a name="create_bulk_buy_numbers"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateBulkBuyNumbers") CreateBulkBuyNumbers

> Purchase a selected number of DID's from specific area codes to be used with your Ytel account.


```csharp
Task<string> CreateBulkBuyNumbers(
        Standard.Models.NumberType2Enum numberType,
        string areaCode,
        string quantity,
        string leftover = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numberType |  ``` Required ```  | The capability the number supports. |
| areaCode |  ``` Required ```  | Specifies the area code for the returned list of available numbers. Only available for North American numbers. |
| quantity |  ``` Required ```  | A positive integer that tells how many number you want to buy at a time. |
| leftover |  ``` Optional ```  | If desired quantity is unavailable purchase what is available . |


#### Example Usage

```csharp
var numberType = Standard.Models.NumberType2EnumHelper.ParseString("all");
string areaCode = "AreaCode";
string quantity = "Quantity";
string leftover = "Leftover";

string result = await phoneNumber.CreateBulkBuyNumbers(numberType, areaCode, quantity, leftover);

```


### <a name="create_bulk_update_numbers"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateBulkUpdateNumbers") CreateBulkUpdateNumbers

> Update properties for a Ytel numbers that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.


```csharp
Task<string> CreateBulkUpdateNumbers(
        string phoneNumber,
        string voiceUrl,
        string friendlyName = null,
        string voiceMethod = null,
        string voiceFallbackUrl = null,
        string voiceFallbackMethod = null,
        string hangupCallback = null,
        string hangupCallbackMethod = null,
        string heartbeatUrl = null,
        string heartbeatMethod = null,
        string smsUrl = null,
        string smsMethod = null,
        string smsFallbackUrl = null,
        string smsFallbackMethod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid comma(,) separated Ytel numbers. (E.164 format). |
| voiceUrl |  ``` Required ```  | The URL returning InboundXML incoming calls should execute when connected. |
| friendlyName |  ``` Optional ```  | A human-readable value for labeling the number. |
| voiceMethod |  ``` Optional ```  | Specifies the HTTP method used to request the VoiceUrl once incoming call connects. |
| voiceFallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML on a call or at initial request of the voice url |
| voiceFallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the VoiceFallbackUrl once incoming call connects. |
| hangupCallback |  ``` Optional ```  | URL that can be requested to receive notification when and how incoming call has ended. |
| hangupCallbackMethod |  ``` Optional ```  | The HTTP method Ytel will use when requesting the HangupCallback URL. |
| heartbeatUrl |  ``` Optional ```  | URL that can be used to monitor the phone number. |
| heartbeatMethod |  ``` Optional ```  | The HTTP method Ytel will use when requesting the HeartbeatUrl. |
| smsUrl |  ``` Optional ```  | URL requested when an SMS is received. |
| smsMethod |  ``` Optional ```  | The HTTP method Ytel will use when requesting the SmsUrl. |
| smsFallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML from an SMS or at initial request of the SmsUrl. |
| smsFallbackMethod |  ``` Optional ```  | The HTTP method Ytel will use when URL requested if the SmsUrl is not available. |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";
string voiceUrl = "VoiceUrl";
string friendlyName = "FriendlyName";
string voiceMethod = "VoiceMethod";
string voiceFallbackUrl = "VoiceFallbackUrl";
string voiceFallbackMethod = "VoiceFallbackMethod";
string hangupCallback = "HangupCallback";
string hangupCallbackMethod = "HangupCallbackMethod";
string heartbeatUrl = "HeartbeatUrl";
string heartbeatMethod = "HeartbeatMethod";
string smsUrl = "SmsUrl";
string smsMethod = "SmsMethod";
string smsFallbackUrl = "SmsFallbackUrl";
string smsFallbackMethod = "SmsFallbackMethod";

string result = await phoneNumber.CreateBulkUpdateNumbers(phoneNumber, voiceUrl, friendlyName, voiceMethod, voiceFallbackUrl, voiceFallbackMethod, hangupCallback, hangupCallbackMethod, heartbeatUrl, heartbeatMethod, smsUrl, smsMethod, smsFallbackUrl, smsFallbackMethod);

```


### <a name="create_move_number"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateMoveNumber") CreateMoveNumber

> Transfer phone number that has been purchased for from one account to another account.


```csharp
Task<string> CreateMoveNumber(string phonenumber, string fromaccountsid, string toaccountsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |
| fromaccountsid |  ``` Required ```  | A specific Accountsid from where Number is getting transfer. |
| toaccountsid |  ``` Required ```  | A specific Accountsid to which Number is getting transfer. |


#### Example Usage

```csharp
string phonenumber = "phonenumber";
string fromaccountsid = "fromaccountsid";
string toaccountsid = "toaccountsid";

string result = await phoneNumber.CreateMoveNumber(phonenumber, fromaccountsid, toaccountsid);

```


### <a name="create_list_numbers"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateListNumbers") CreateListNumbers

> Retrieve a list of purchased phones numbers associated with your Ytel account.


```csharp
Task<string> CreateListNumbers(
        int? page = null,
        int? pageSize = null,
        Standard.Models.NumberTypeEnum? numberType = null,
        string friendlyName = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| numberType |  ``` Optional ```  | The capability supported by the number.Number type either SMS,Voice or all |
| friendlyName |  ``` Optional ```  | A human-readable label added to the number object. |


#### Example Usage

```csharp
int? page = 118;
int? pageSize = 118;
var numberType = Standard.Models.NumberTypeEnum?Helper.ParseString("all");
string friendlyName = "FriendlyName";

string result = await phoneNumber.CreateListNumbers(page, pageSize, numberType, friendlyName);

```


### <a name="update_number"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.UpdateNumber") UpdateNumber

> Update properties for a Ytel number that has been purchased for your account. Refer to the parameters list for the list of properties that can be updated.


```csharp
Task<string> UpdateNumber(
        string phoneNumber,
        string voiceUrl,
        string friendlyName = null,
        string voiceMethod = null,
        string voiceFallbackUrl = null,
        string voiceFallbackMethod = null,
        string hangupCallback = null,
        string hangupCallbackMethod = null,
        string heartbeatUrl = null,
        string heartbeatMethod = null,
        string smsUrl = null,
        string smsMethod = null,
        string smsFallbackUrl = null,
        string smsFallbackMethod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel number (E.164 format). |
| voiceUrl |  ``` Required ```  | URL requested once the call connects |
| friendlyName |  ``` Optional ```  | Phone number friendly name description |
| voiceMethod |  ``` Optional ```  | Post or Get |
| voiceFallbackUrl |  ``` Optional ```  | URL requested if the voice URL is not available |
| voiceFallbackMethod |  ``` Optional ```  | Post or Get |
| hangupCallback |  ``` Optional ```  | callback url after a hangup occurs |
| hangupCallbackMethod |  ``` Optional ```  | Post or Get |
| heartbeatUrl |  ``` Optional ```  | URL requested once the call connects |
| heartbeatMethod |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed time |
| smsUrl |  ``` Optional ```  | URL requested when an SMS is received |
| smsMethod |  ``` Optional ```  | Post or Get |
| smsFallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML from an SMS or at initial request of the SmsUrl. |
| smsFallbackMethod |  ``` Optional ```  | The HTTP method Ytel will use when URL requested if the SmsUrl is not available. |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";
string voiceUrl = "VoiceUrl";
string friendlyName = "FriendlyName";
string voiceMethod = "VoiceMethod";
string voiceFallbackUrl = "VoiceFallbackUrl";
string voiceFallbackMethod = "VoiceFallbackMethod";
string hangupCallback = "HangupCallback";
string hangupCallbackMethod = "HangupCallbackMethod";
string heartbeatUrl = "HeartbeatUrl";
string heartbeatMethod = "HeartbeatMethod";
string smsUrl = "SmsUrl";
string smsMethod = "SmsMethod";
string smsFallbackUrl = "SmsFallbackUrl";
string smsFallbackMethod = "SmsFallbackMethod";

string result = await phoneNumber.UpdateNumber(phoneNumber, voiceUrl, friendlyName, voiceMethod, voiceFallbackUrl, voiceFallbackMethod, hangupCallback, hangupCallbackMethod, heartbeatUrl, heartbeatMethod, smsUrl, smsMethod, smsFallbackUrl, smsFallbackMethod);

```


### <a name="create_view_details"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateViewDetails") CreateViewDetails

> Retrieve the details for a phone number by its number.


```csharp
Task<string> CreateViewDetails(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit Ytel number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreateViewDetails(phoneNumber);

```


### <a name="create_release_number"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateReleaseNumber") CreateReleaseNumber

> Remove a purchased Ytel number from your account.


```csharp
Task<string> CreateReleaseNumber(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel 10-digit phone number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreateReleaseNumber(phoneNumber);

```


### <a name="create_purchase_number"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreatePurchaseNumber") CreatePurchaseNumber

> Purchase a phone number to be used with your Ytel account


```csharp
Task<string> CreatePurchaseNumber(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel 10-digit phone number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreatePurchaseNumber(phoneNumber);

```


### <a name="create_get_did_score"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateGetDIDScore") CreateGetDIDScore

> Get DID Score Number


```csharp
Task<string> CreateGetDIDScore(string phonenumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | Specifies the multiple phone numbers for check updated spamscore . |


#### Example Usage

```csharp
string phonenumber = "Phonenumber";

string result = await phoneNumber.CreateGetDIDScore(phonenumber);

```


### <a name="create_available_numbers"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateAvailableNumbers") CreateAvailableNumbers

> Retrieve a list of available phone numbers that can be purchased and used for your Ytel account.


```csharp
Task<string> CreateAvailableNumbers(Standard.Models.Numbertype1Enum numbertype, string areacode, int? pagesize = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numbertype |  ``` Required ```  | Number type either SMS,Voice or all |
| areacode |  ``` Required ```  | Specifies the area code for the returned list of available numbers. Only available for North American numbers. |
| pagesize |  ``` Optional ```  | The count of objects to return. |


#### Example Usage

```csharp
var numbertype = Standard.Models.Numbertype1EnumHelper.ParseString("all");
string areacode = "areacode";
int? pagesize = 76;

string result = await phoneNumber.CreateAvailableNumbers(numbertype, areacode, pagesize);

```


### <a name="create_bulk_release"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.PhoneNumberController.CreateBulkRelease") CreateBulkRelease

> Remove a purchased Ytel number from your account.


```csharp
Task<string> CreateBulkRelease(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid Ytel comma separated numbers (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await phoneNumber.CreateBulkRelease(phoneNumber);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="carrier_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.CarrierController") CarrierController

### Get singleton instance

The singleton instance of the ``` CarrierController ``` class can be accessed from the API Client.

```csharp
CarrierController carrier = client.Carrier;
```

### <a name="create_lookup_carrier"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.CarrierController.CreateLookupCarrier") CreateLookupCarrier

> Get the Carrier Lookup


```csharp
Task<string> CreateLookupCarrier(string phoneNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | A valid 10-digit number (E.164 format). |


#### Example Usage

```csharp
string phoneNumber = "PhoneNumber";

string result = await carrier.CreateLookupCarrier(phoneNumber);

```


### <a name="create_carrier_results"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.CarrierController.CreateCarrierResults") CreateCarrierResults

> Retrieve a list of carrier lookup objects.


```csharp
Task<string> CreateCarrierResults(int? page = null, int? pageSize = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  | The count of objects to return per page. |


#### Example Usage

```csharp
int? page = 76;
int? pageSize = 76;

string result = await carrier.CreateCarrierResults(page, pageSize);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="dedicated_short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController") DedicatedShortCodeController

### Get singleton instance

The singleton instance of the ``` DedicatedShortCodeController ``` class can be accessed from the API Client.

```csharp
DedicatedShortCodeController dedicatedShortCode = client.DedicatedShortCode;
```

### <a name="update_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.UpdateShortcode") UpdateShortcode

> Update a dedicated shortcode.


```csharp
Task<string> UpdateShortcode(
        string shortcode,
        string friendlyName = null,
        string callbackMethod = null,
        string callbackUrl = null,
        string fallbackMethod = null,
        string fallbackUrl = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid dedicated shortcode to your Ytel account. |
| friendlyName |  ``` Optional ```  | User generated name of the dedicated shortcode. |
| callbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |
| callbackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| fallbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| fallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST. |


#### Example Usage

```csharp
string shortcode = "Shortcode";
string friendlyName = "FriendlyName";
string callbackMethod = "CallbackMethod";
string callbackUrl = "CallbackUrl";
string fallbackMethod = "FallbackMethod";
string fallbackUrl = "FallbackUrl";

string result = await dedicatedShortCode.UpdateShortcode(shortcode, friendlyName, callbackMethod, callbackUrl, fallbackMethod, fallbackUrl);

```


### <a name="create_list_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.CreateListShortcodes") CreateListShortcodes

> Retrieve a list of Short Code assignment associated with your Ytel account.


```csharp
Task<string> CreateListShortcodes(string shortcode = null, string page = null, string pagesize = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Optional ```  | Only list Short Code Assignment sent from this Short Code |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |


#### Example Usage

```csharp
string shortcode = "Shortcode";
string page = "page";
string pagesize = "pagesize";

string result = await dedicatedShortCode.CreateListShortcodes(shortcode, page, pagesize);

```


### <a name="create_list_inbound_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.CreateListInboundSMS") CreateListInboundSMS

> Retrive a list of inbound Sms Short Code messages associated with your Ytel account.


```csharp
Task<string> CreateListInboundSMS(
        int? page = null,
        int? pagesize = null,
        string mfrom = null,
        string shortcode = null,
        string datecreated = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Only list SMS messages sent from this number |
| shortcode |  ``` Optional ```  | Only list SMS messages sent to Shortcode |
| datecreated |  ``` Optional ```  | Only list SMS messages sent in the specified date MAKE REQUEST |


#### Example Usage

```csharp
int? page = 167;
int? pagesize = 167;
string mfrom = "From";
string shortcode = "Shortcode";
string datecreated = "Datecreated";

string result = await dedicatedShortCode.CreateListInboundSMS(page, pagesize, mfrom, shortcode, datecreated);

```


### <a name="create_view_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.CreateViewSMS") CreateViewSMS

> Retrieve a single Short Code object by its shortcode assignment.


```csharp
Task<string> CreateViewSMS(string shortcode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Dedicated Short Code to your Ytel account |


#### Example Usage

```csharp
string shortcode = "Shortcode";

string result = await dedicatedShortCode.CreateViewSMS(shortcode);

```


### <a name="create_list_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.CreateListSMS") CreateListSMS

> Retrieve a list of Short Code messages.


```csharp
Task<string> CreateListSMS(
        string shortcode = null,
        string to = null,
        string dateSent = null,
        int? page = null,
        int? pageSize = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Optional ```  | Only list messages sent from this Short Code |
| to |  ``` Optional ```  | Only list messages sent to this number |
| dateSent |  ``` Optional ```  | Only list messages sent with the specified date |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  | The count of objects to return per page. |


#### Example Usage

```csharp
string shortcode = "Shortcode";
string to = "To";
string dateSent = "DateSent";
int? page = 167;
int? pageSize = 167;

string result = await dedicatedShortCode.CreateListSMS(shortcode, to, dateSent, page, pageSize);

```


### <a name="create_send_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.CreateSendSMS") CreateSendSMS

> Send Dedicated Shortcode


```csharp
Task<string> CreateSendSMS(
        int shortcode,
        double to,
        string body,
        string method = null,
        string messagestatuscallback = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | Your dedicated shortcode |
| to |  ``` Required ```  | The number to send your SMS to |
| body |  ``` Required ```  | The body of your message |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent.GET or POST |
| messagestatuscallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |


#### Example Usage

```csharp
int shortcode = 167;
double to = 167.808611196377;
string body = "body";
string method = "method";
string messagestatuscallback = "messagestatuscallback";

string result = await dedicatedShortCode.CreateSendSMS(shortcode, to, body, method, messagestatuscallback);

```


### <a name="create_view_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.DedicatedShortCodeController.CreateViewSMS") CreateViewSMS

> View a single Sms Short Code message.


```csharp
Task<string> CreateViewSMS(string messageSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for the sms resource |


#### Example Usage

```csharp
string messageSid = "MessageSid";

string result = await dedicatedShortCode.CreateViewSMS(messageSid);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="shared_short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.SharedShortCodeController") SharedShortCodeController

### Get singleton instance

The singleton instance of the ``` SharedShortCodeController ``` class can be accessed from the API Client.

```csharp
SharedShortCodeController sharedShortCode = client.SharedShortCode;
```

### <a name="create_list_shortcodes"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateListShortcodes") CreateListShortcodes

> Retrieve a list of shortcode assignment associated with your Ytel account.


```csharp
Task<string> CreateListShortcodes(string shortcode = null, int? page = null, int? pagesize = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |


#### Example Usage

```csharp
string shortcode = "Shortcode";
int? page = 167;
int? pagesize = 167;

string result = await sharedShortCode.CreateListShortcodes(shortcode, page, pagesize);

```


### <a name="update_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.UpdateShortcode") UpdateShortcode

> Update Assignment


```csharp
Task<string> UpdateShortcode(
        string shortcode,
        string friendlyName = null,
        string callbackUrl = null,
        string callbackMethod = null,
        string fallbackUrl = null,
        string fallbackUrlMethod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid shortcode to your Ytel account |
| friendlyName |  ``` Optional ```  | User generated name of the shortcode |
| callbackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| callbackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |
| fallbackUrl |  ``` Optional ```  | URL used if any errors occur during execution of InboundXML or at initial request of the required Url provided with the POST. |
| fallbackUrlMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |


#### Example Usage

```csharp
string shortcode = "Shortcode";
string friendlyName = "FriendlyName";
string callbackUrl = "CallbackUrl";
string callbackMethod = "CallbackMethod";
string fallbackUrl = "FallbackUrl";
string fallbackUrlMethod = "FallbackUrlMethod";

string result = await sharedShortCode.UpdateShortcode(shortcode, friendlyName, callbackUrl, callbackMethod, fallbackUrl, fallbackUrlMethod);

```


### <a name="create_list_keywords"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateListKeywords") CreateListKeywords

> Retrieve a list of keywords associated with your Ytel account.


```csharp
Task<string> CreateListKeywords(
        int? page = null,
        int? pagesize = null,
        string keyword = null,
        int? shortcode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| keyword |  ``` Optional ```  | Only list keywords of keyword |
| shortcode |  ``` Optional ```  | Only list keywords of shortcode |


#### Example Usage

```csharp
int? page = 167;
int? pagesize = 167;
string keyword = "Keyword";
int? shortcode = 167;

string result = await sharedShortCode.CreateListKeywords(page, pagesize, keyword, shortcode);

```


### <a name="create_view_shortcode"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateViewShortcode") CreateViewShortcode

> The response returned here contains all resource properties associated with the given Shortcode.


```csharp
Task<string> CreateViewShortcode(string shortcode)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | List of valid Shortcode to your Ytel account |


#### Example Usage

```csharp
string shortcode = "Shortcode";

string result = await sharedShortCode.CreateViewShortcode(shortcode);

```


### <a name="create_send_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateSendSMS") CreateSendSMS

> Send an SMS from a Ytel ShortCode


```csharp
Task<string> CreateSendSMS(
        string shortcode,
        string to,
        Guid templateid,
        string data,
        string method = null,
        string messageStatusCallback = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | The Short Code number that is the sender of this message |
| to |  ``` Required ```  | A valid 10-digit number that should receive the message |
| templateid |  ``` Required ```  | The unique identifier for the template used for the message |
| data |  ``` Required ```  | format of your data, example: {companyname}:test,{otpcode}:1234 |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |


#### Example Usage

```csharp
string shortcode = "shortcode";
string to = "to";
Guid templateid = Guid.NewGuid();
string data = "data";
string method = "Method";
string messageStatusCallback = "MessageStatusCallback";

string result = await sharedShortCode.CreateSendSMS(shortcode, to, templateid, data, method, messageStatusCallback);

```


### <a name="create_list_templates"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateListTemplates") CreateListTemplates

> List Shortcode Templates by Type


```csharp
Task<string> CreateListTemplates(
        string type = null,
        int? page = null,
        int? pagesize = null,
        string shortcode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Optional ```  | The type (category) of template Valid values: marketing, authorization |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | The count of objects to return per page. |
| shortcode |  ``` Optional ```  | Only list templates of type |


#### Example Usage

```csharp
string type = "type";
int? page = 167;
int? pagesize = 167;
string shortcode = "Shortcode";

string result = await sharedShortCode.CreateListTemplates(type, page, pagesize, shortcode);

```


### <a name="create_view_template"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateViewTemplate") CreateViewTemplate

> View a Shared ShortCode Template


```csharp
Task<string> CreateViewTemplate(Guid templateId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| templateId |  ``` Required ```  | The unique identifier for a template object |


#### Example Usage

```csharp
Guid templateId = Guid.NewGuid();

string result = await sharedShortCode.CreateViewTemplate(templateId);

```


### <a name="create_list_inbound_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateListInboundSMS") CreateListInboundSMS

> List All Inbound ShortCode


```csharp
Task<string> CreateListInboundSMS(
        string datecreated = null,
        int? page = null,
        int? pagesize = null,
        string mfrom = null,
        string shortcode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| datecreated |  ``` Optional ```  | Only list messages sent with the specified date |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound ShortCode |
| shortcode |  ``` Optional ```  | Only list messages sent to this Short Code |


#### Example Usage

```csharp
string datecreated = "Datecreated";
int? page = 167;
int? pagesize = 167;
string mfrom = "from";
string shortcode = "Shortcode";

string result = await sharedShortCode.CreateListInboundSMS(datecreated, page, pagesize, mfrom, shortcode);

```


### <a name="create_view_keyword"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SharedShortCodeController.CreateViewKeyword") CreateViewKeyword

> View a set of properties for a single keyword.


```csharp
Task<string> CreateViewKeyword(string keywordid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| keywordid |  ``` Required ```  | The unique identifier of each keyword |


#### Example Usage

```csharp
string keywordid = "Keywordid";

string result = await sharedShortCode.CreateViewKeyword(keywordid);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sms_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.SMSController") SMSController

### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
SMSController sMS = client.SMS;
```

### <a name="create_list_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SMSController.CreateListSMS") CreateListSMS

> Retrieve a list of Outbound SMS message objects.


```csharp
Task<string> CreateListSMS(
        int? page = null,
        int? pageSize = null,
        string mfrom = null,
        string to = null,
        string dateSent = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Filter SMS message objects from this valid 10-digit phone number (E.164 format). |
| to |  ``` Optional ```  | Filter SMS message objects to this valid 10-digit phone number (E.164 format). |
| dateSent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |


#### Example Usage

```csharp
int? page = 167;
int? pageSize = 167;
string mfrom = "From";
string to = "To";
string dateSent = "DateSent";

string result = await sMS.CreateListSMS(page, pageSize, mfrom, to, dateSent);

```


### <a name="create_list_inbound_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SMSController.CreateListInboundSMS") CreateListInboundSMS

> Retrieve a list of Inbound SMS message objects.


```csharp
Task<string> CreateListInboundSMS(
        int? page = null,
        int? pageSize = null,
        string mfrom = null,
        string to = null,
        string dateSent = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  | The count of objects to return per page. |
| mfrom |  ``` Optional ```  | Filter SMS message objects from this valid 10-digit phone number (E.164 format). |
| to |  ``` Optional ```  | Filter SMS message objects to this valid 10-digit phone number (E.164 format). |
| dateSent |  ``` Optional ```  | Filter sms message objects by this date. |


#### Example Usage

```csharp
int? page = 167;
int? pageSize = 167;
string mfrom = "From";
string to = "To";
string dateSent = "DateSent";

string result = await sMS.CreateListInboundSMS(page, pageSize, mfrom, to, dateSent);

```


### <a name="create_send_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SMSController.CreateSendSMS") CreateSendSMS

> Send an SMS from a Ytel number


```csharp
Task<string> CreateSendSMS(
        string mfrom,
        string to,
        string body,
        string method = null,
        string messageStatusCallback = null,
        bool? smartsms = null,
        bool? deliveryStatus = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | The 10-digit SMS-enabled Ytel number (E.164 format) in which the message is sent. |
| to |  ``` Required ```  | The 10-digit phone number (E.164 format) that will receive the message. |
| body |  ``` Required ```  | The body message that is to be sent in the text. |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once SMS sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished. |
| smartsms |  ``` Optional ```  | Check's 'to' number can receive sms or not using Carrier API, if wireless = true then text sms is sent, else wireless = false then call is recieved to end user with audible message. |
| deliveryStatus |  ``` Optional ```  | Delivery reports are a method to tell your system if the message has arrived on the destination phone. |


#### Example Usage

```csharp
string mfrom = "From";
string to = "To";
string body = "Body";
string method = "Method";
string messageStatusCallback = "MessageStatusCallback";
bool? smartsms = true;
bool? deliveryStatus = true;

string result = await sMS.CreateSendSMS(mfrom, to, body, method, messageStatusCallback, smartsms, deliveryStatus);

```


### <a name="create_view_sms"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SMSController.CreateViewSMS") CreateViewSMS

> Retrieve a single SMS message object by its SmsSid.


```csharp
Task<string> CreateViewSMS(string messageSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for a sms message. |


#### Example Usage

```csharp
string messageSid = "MessageSid";

string result = await sMS.CreateViewSMS(messageSid);

```


### <a name="create_view_sms_details"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.SMSController.CreateViewSMSDetails") CreateViewSMSDetails

> Retrieve a single SMS message object with details by its SmsSid.


```csharp
Task<string> CreateViewSMSDetails(string messageSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messageSid |  ``` Required ```  | The unique identifier for a sms message. |


#### Example Usage

```csharp
string messageSid = "MessageSid";

string result = await sMS.CreateViewSMSDetails(messageSid);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="voice_controller"></a>![Class: ](https://apidocs.io/img/class.png "YtelAPI.Tests.Controllers.VoiceController") VoiceController

### Get singleton instance

The singleton instance of the ``` VoiceController ``` class can be accessed from the API Client.

```csharp
VoiceController voice = client.Voice;
```

### <a name="create_send_rvm"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateSendRVM") CreateSendRVM

> Initiate an outbound Ringless Voicemail through Ytel.


```csharp
Task<string> CreateSendRVM(
        string mfrom,
        string rVMCallerId,
        string to,
        string voiceMailURL,
        string method = null,
        string statusCallBackUrl = null,
        string statsCallBackMethod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| rVMCallerId |  ``` Required ```  | A required secondary Caller ID for RVM to work. |
| to |  ``` Required ```  | A valid number (E.164 format) that will receive the phone call. |
| voiceMailURL |  ``` Required ```  | The URL requested once the RVM connects. A set of default parameters will be sent here. |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statsCallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required StatusCallBackUrl once call connects. |


#### Example Usage

```csharp
string mfrom = "From";
string rVMCallerId = "RVMCallerId";
string to = "To";
string voiceMailURL = "VoiceMailURL";
string method = "Method";
string statusCallBackUrl = "StatusCallBackUrl";
string statsCallBackMethod = "StatsCallBackMethod";

string result = await voice.CreateSendRVM(mfrom, rVMCallerId, to, voiceMailURL, method, statusCallBackUrl, statsCallBackMethod);

```


### <a name="create_view_call"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateViewCall") CreateViewCall

> Retrieve a single voice call’s information by its CallSid.


```csharp
Task<string> CreateViewCall(string callsid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callsid |  ``` Required ```  | The unique identifier for the voice call. |


#### Example Usage

```csharp
string callsid = "callsid";

string result = await voice.CreateViewCall(callsid);

```


### <a name="create_view_call_details"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateViewCallDetails") CreateViewCallDetails

> Retrieve a single voice call’s information by its CallSid.


```csharp
Task<string> CreateViewCallDetails(string callSid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the voice call. |


#### Example Usage

```csharp
string callSid = "callSid";

string result = await voice.CreateViewCallDetails(callSid);

```


### <a name="create_interrupt_call"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateInterruptCall") CreateInterruptCall

> Interrupt the Call by Call Sid


```csharp
Task<string> CreateInterruptCall(
        string callSid,
        string url = null,
        string method = null,
        Standard.Models.Status1Enum? status = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for voice call that is in progress. |
| url |  ``` Optional ```  | URL the in-progress call will be redirected to |
| method |  ``` Optional ```  | The method used to request the above Url parameter |
| status |  ``` Optional ```  | Status to set the in-progress call to |


#### Example Usage

```csharp
string callSid = "CallSid";
string url = "Url";
string method = "Method";
var status = Standard.Models.Status1Enum?Helper.ParseString("canceled");

string result = await voice.CreateInterruptCall(callSid, url, method, status);

```


### <a name="create_list_calls"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateListCalls") CreateListCalls

> A list of calls associated with your Ytel account


```csharp
Task<string> CreateListCalls(
        int? page = null,
        int? pageSize = null,
        string to = null,
        string mfrom = null,
        string dateCreated = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| to |  ``` Optional ```  | Filter calls that were sent to this 10-digit number (E.164 format). |
| mfrom |  ``` Optional ```  | Filter calls that were sent from this 10-digit number (E.164 format). |
| dateCreated |  ``` Optional ```  | Return calls that are from a specified date. |


#### Example Usage

```csharp
int? page = 167;
int? pageSize = 167;
string to = "To";
string mfrom = "From";
string dateCreated = "DateCreated";

string result = await voice.CreateListCalls(page, pageSize, to, mfrom, dateCreated);

```


### <a name="create_voice_effect"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateVoiceEffect") CreateVoiceEffect

> Add audio voice effects to the an in-progress voice call.


```csharp
Task<string> CreateVoiceEffect(
        string callSid,
        Standard.Models.AudioDirectionEnum? audioDirection = null,
        double? pitchSemiTones = null,
        double? pitchOctaves = null,
        double? pitch = null,
        double? rate = null,
        double? tempo = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier for the in-progress voice call. |
| audioDirection |  ``` Optional ```  | The direction the audio effect should be placed on. If IN, the effects will occur on the incoming audio stream. If OUT, the effects will occur on the outgoing audio stream. |
| pitchSemiTones |  ``` Optional ```  | Set the pitch in semitone (half-step) intervals. Value between -14 and 14 |
| pitchOctaves |  ``` Optional ```  | Set the pitch in octave intervals.. Value between -1 and 1 |
| pitch |  ``` Optional ```  | Set the pitch (lowness/highness) of the audio. The higher the value, the higher the pitch. Value greater than 0 |
| rate |  ``` Optional ```  | Set the rate for audio. The lower the value, the lower the rate. value greater than 0 |
| tempo |  ``` Optional ```  | Set the tempo (speed) of the audio. A higher value denotes a faster tempo. Value greater than 0 |


#### Example Usage

```csharp
string callSid = "CallSid";
var audioDirection = Standard.Models.AudioDirectionEnum?Helper.ParseString("in");
double? pitchSemiTones = 167.808611196377;
double? pitchOctaves = 167.808611196377;
double? pitch = 167.808611196377;
double? rate = 167.808611196377;
double? tempo = 167.808611196377;

string result = await voice.CreateVoiceEffect(callSid, audioDirection, pitchSemiTones, pitchOctaves, pitch, rate, tempo);

```


### <a name="create_play_audio"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreatePlayAudio") CreatePlayAudio

> Play Audio from a url


```csharp
Task<string> CreatePlayAudio(
        string callSid,
        string audioUrl,
        string sayText,
        int? length = null,
        Standard.Models.Direction1Enum? direction = null,
        bool? mix = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| audioUrl |  ``` Required ```  | URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav |
| sayText |  ``` Required ```  | Valid alphanumeric string that should be played to the In-progress call. |
| length |  ``` Optional ```  | Time limit in seconds for audio play back |
| direction |  ``` Optional ```  | The leg of the call audio will be played to |
| mix |  ``` Optional ```  | If false, all other audio will be muted |


#### Example Usage

```csharp
string callSid = "CallSid";
string audioUrl = "AudioUrl";
string sayText = "SayText";
int? length = 167;
var direction = Standard.Models.Direction1Enum?Helper.ParseString("in");
bool? mix = true;

string result = await voice.CreatePlayAudio(callSid, audioUrl, sayText, length, direction, mix);

```


### <a name="create_record_call"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateRecordCall") CreateRecordCall

> Start or stop recording of an in-progress voice call.


```csharp
Task<string> CreateRecordCall(
        string callSid,
        bool record,
        Standard.Models.DirectionEnum? direction = null,
        int? timeLimit = null,
        string callBackUrl = null,
        Standard.Models.FileformatEnum? fileformat = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| record |  ``` Required ```  | Set true to initiate recording or false to terminate recording |
| direction |  ``` Optional ```  | The leg of the call to record |
| timeLimit |  ``` Optional ```  | Time in seconds the recording duration should not exceed |
| callBackUrl |  ``` Optional ```  | URL consulted after the recording completes |
| fileformat |  ``` Optional ```  | Format of the recording file. Can be .mp3 or .wav |


#### Example Usage

```csharp
string callSid = "CallSid";
bool record = true;
var direction = Standard.Models.DirectionEnum?Helper.ParseString("in");
int? timeLimit = 167;
string callBackUrl = "CallBackUrl";
var fileformat = Standard.Models.FileformatEnum?Helper.ParseString("mp3");

string result = await voice.CreateRecordCall(callSid, record, direction, timeLimit, callBackUrl, fileformat);

```


### <a name="create_play_dtmf"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreatePlayDTMF") CreatePlayDTMF

> Play Dtmf and send the Digit


```csharp
Task<string> CreatePlayDTMF(string callSid, string playDtmf, Standard.Models.PlayDtmfDirectionEnum? playDtmfDirection = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| playDtmf |  ``` Required ```  | DTMF digits to play to the call. 0-9, #, *, W, or w |
| playDtmfDirection |  ``` Optional ```  | The leg of the call DTMF digits should be sent to |


#### Example Usage

```csharp
string callSid = "CallSid";
string playDtmf = "PlayDtmf";
var playDtmfDirection = Standard.Models.PlayDtmfDirectionEnum?Helper.ParseString("in");

string result = await voice.CreatePlayDTMF(callSid, playDtmf, playDtmfDirection);

```


### <a name="create_group_call"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateGroupCall") CreateGroupCall

> You can experiment with initiating a call through Ytel and view the request response generated when doing so and get the response in json


```csharp
Task<string> CreateGroupCall(
        string mfrom,
        string to,
        string url,
        string groupConfirmKey,
        Standard.Models.GroupConfirmFileEnum groupConfirmFile,
        string method = null,
        string statusCallBackUrl = null,
        string statusCallBackMethod = null,
        string fallBackUrl = null,
        string fallBackMethod = null,
        string heartBeatUrl = null,
        string heartBeatMethod = null,
        int? timeout = null,
        string playDtmf = null,
        string hideCallerId = null,
        bool? record = null,
        string recordCallBackUrl = null,
        string recordCallBackMethod = null,
        bool? transcribe = null,
        string transcribeCallBackUrl = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| to |  ``` Required ```  | Please enter multiple E164 number. You can add max 10 numbers. Add numbers separated with comma. e.g : +12223334444,+15556667777 |
| url |  ``` Required ```  | URL requested once the call connects |
| groupConfirmKey |  ``` Required ```  | Define the DTMF that the called party should send to bridge the call. Allowed Values : 0-9, #, * |
| groupConfirmFile |  ``` Required ```  | Specify the audio file you want to play when the called party picks up the call |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| heartBeatUrl |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed time and pass other general information. |
| heartBeatMethod |  ``` Optional ```  | Specifies the HTTP method used to request HeartbeatUrl. |
| timeout |  ``` Optional ```  | Time (in seconds) we should wait while the call is ringing before canceling the call |
| playDtmf |  ``` Optional ```  | DTMF Digits to play to the call once it connects. 0-9, #, or * |
| hideCallerId |  ``` Optional ```  | Specifies if the caller id will be hidden |
| record |  ``` Optional ```  | Specifies if the call should be recorded |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion |
| recordCallBackMethod |  ``` Optional ```  | Method used to request the RecordCallback URL. |
| transcribe |  ``` Optional ```  | Specifies if the call recording should be transcribed |
| transcribeCallBackUrl |  ``` Optional ```  | Transcription parameters will be sent here upon completion |


#### Example Usage

```csharp
string mfrom = "From";
string to = "To";
string url = "Url";
string groupConfirmKey = "GroupConfirmKey";
var groupConfirmFile = Standard.Models.GroupConfirmFileEnumHelper.ParseString("mp3");
string method = "Method";
string statusCallBackUrl = "StatusCallBackUrl";
string statusCallBackMethod = "StatusCallBackMethod";
string fallBackUrl = "FallBackUrl";
string fallBackMethod = "FallBackMethod";
string heartBeatUrl = "HeartBeatUrl";
string heartBeatMethod = "HeartBeatMethod";
int? timeout = 126;
string playDtmf = "PlayDtmf";
string hideCallerId = "HideCallerId";
bool? record = false;
string recordCallBackUrl = "RecordCallBackUrl";
string recordCallBackMethod = "RecordCallBackMethod";
bool? transcribe = false;
string transcribeCallBackUrl = "TranscribeCallBackUrl";

string result = await voice.CreateGroupCall(mfrom, to, url, groupConfirmKey, groupConfirmFile, method, statusCallBackUrl, statusCallBackMethod, fallBackUrl, fallBackMethod, heartBeatUrl, heartBeatMethod, timeout, playDtmf, hideCallerId, record, recordCallBackUrl, recordCallBackMethod, transcribe, transcribeCallBackUrl);

```


### <a name="create_make_call"></a>![Method: ](https://apidocs.io/img/method.png "YtelAPI.Tests.Controllers.VoiceController.CreateMakeCall") CreateMakeCall

> You can experiment with initiating a call through Ytel and view the request response generated when doing so and get the response in json


```csharp
Task<string> CreateMakeCall(
        string mfrom,
        string to,
        string url,
        string method = null,
        string statusCallBackUrl = null,
        string statusCallBackMethod = null,
        string fallBackUrl = null,
        string fallBackMethod = null,
        string heartBeatUrl = null,
        string heartBeatMethod = null,
        int? timeout = null,
        string playDtmf = null,
        bool? hideCallerId = null,
        bool? record = null,
        string recordCallBackUrl = null,
        string recordCallBackMethod = null,
        bool? transcribe = null,
        string transcribeCallBackUrl = null,
        Standard.Models.IfMachineEnum? ifMachine = null,
        string ifMachineUrl = null,
        string ifMachineMethod = null,
        bool? feedback = null,
        string surveyId = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mfrom |  ``` Required ```  | A valid Ytel Voice enabled number (E.164 format) that will be initiating the phone call. |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | URL that can be requested to receive notification when call has ended. A set of default parameters will be sent here once the call is finished. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| heartBeatUrl |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed tim |
| heartBeatMethod |  ``` Optional ```  | Specifies the HTTP method used to request HeartbeatUrl. |
| timeout |  ``` Optional ```  | Time (in seconds) Ytel should wait while the call is ringing before canceling the call |
| playDtmf |  ``` Optional ```  | DTMF Digits to play to the call once it connects. 0-9, #, or * |
| hideCallerId |  ``` Optional ```  | Specifies if the caller id will be hidden |
| record |  ``` Optional ```  | Specifies if the call should be recorded |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion |
| recordCallBackMethod |  ``` Optional ```  | Method used to request the RecordCallback URL. |
| transcribe |  ``` Optional ```  | Specifies if the call recording should be transcribed |
| transcribeCallBackUrl |  ``` Optional ```  | Transcription parameters will be sent here upon completion |
| ifMachine |  ``` Optional ```  | How Ytel should handle the receiving numbers voicemail machine |
| ifMachineUrl |  ``` Optional ```  | URL requested when IfMachine=continue |
| ifMachineMethod |  ``` Optional ```  | Method used to request the IfMachineUrl. |
| feedback |  ``` Optional ```  | Specify if survey should be enable or not |
| surveyId |  ``` Optional ```  | The unique identifier for the survey. |


#### Example Usage

```csharp
string mfrom = "From";
string to = "To";
string url = "Url";
string method = "Method";
string statusCallBackUrl = "StatusCallBackUrl";
string statusCallBackMethod = "StatusCallBackMethod";
string fallBackUrl = "FallBackUrl";
string fallBackMethod = "FallBackMethod";
string heartBeatUrl = "HeartBeatUrl";
string heartBeatMethod = "HeartBeatMethod";
int? timeout = 126;
string playDtmf = "PlayDtmf";
bool? hideCallerId = false;
bool? record = false;
string recordCallBackUrl = "RecordCallBackUrl";
string recordCallBackMethod = "RecordCallBackMethod";
bool? transcribe = false;
string transcribeCallBackUrl = "TranscribeCallBackUrl";
var ifMachine = Standard.Models.IfMachineEnum?Helper.ParseString("continue");
string ifMachineUrl = "IfMachineUrl";
string ifMachineMethod = "IfMachineMethod";
bool? feedback = false;
string surveyId = "SurveyId";

string result = await voice.CreateMakeCall(mfrom, to, url, method, statusCallBackUrl, statusCallBackMethod, fallBackUrl, fallBackMethod, heartBeatUrl, heartBeatMethod, timeout, playDtmf, hideCallerId, record, recordCallBackUrl, recordCallBackMethod, transcribe, transcribeCallBackUrl, ifMachine, ifMachineUrl, ifMachineMethod, feedback, surveyId);

```


[Back to List of Controllers](#list_of_controllers)



