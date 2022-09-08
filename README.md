<h1 align="center">My Budget</h1>

<div align="left">
  <h3> Introduction </h3>
    <p>
      'My Budget' is a program designed to help its users better visualise their spending habits. 
      You import your transactions from a CSV file, downloaded from your bank account and the program will 
      auto-categorise them based on specifications you've set.
      You then save this data to a database on your local machine and the program uses the aggregated data to populate a series of interactive graphs
      to help you visualise your spending habits.
    </p>
    <p>
      'My Budget' is a portfolio project used to better my understanding of software engineering as well as reading and writing data from external sources.
      It has dramatically increased my understanding of how to structure a program and how data flows between classes. It has also allowed me to better
      understand working with databases, specifically how to structure SQL statements.     
    </p>
<div>

<div align="left">
  <h3> Technologies </h3>
  <P>'My Budget' was built in the .NET Framework using Windows Forms in Visual Studio.</p>
  <P> * Code: C#</p>
  <P> * Database: SQLite</p>
</div>

<div>
  <h3> Illustrations </h3>
    <p>Landing Form</p>
    <img src="https://user-images.githubusercontent.com/17680671/189035115-733eae28-5dcb-4d4d-ad35-284b544589e7.png">
    <p>Import Form</p>
    <img src="https://user-images.githubusercontent.com/17680671/189026348-91dcab6b-00e2-4590-afa0-42b6431183bd.png">
    <p>All Transactions Form</p>
    <img src="https://user-images.githubusercontent.com/17680671/189026383-6b7f7286-cad7-4f0e-b147-27c309227752.png">
    <p>All Categories Form</p>
    <img src="https://user-images.githubusercontent.com/17680671/189026364-9da972ca-48ae-4e31-bfe6-488c600bee40.png">
    <p>Create Custom Category Form</p>
    <img src="https://user-images.githubusercontent.com/17680671/189023273-0f9663b3-d6c8-45b7-a71e-61b89afdddf1.jpg">
</div>

<div>
  <h3> Launch </h3>
    <p>
      The program can be cloned to and launched in Viusal Studio.
    </p>
</div>
  
<div>
  <h3> Features </h3>
    <p> * Create custom categories to auto-categorise transactions by. Set a string that is used to search through each transactions description
    and the corresponding category it'll be set to if that string is found in a transactions description. Save them to your local database. </p>
    <p> * Imprort a CSV file of your transactions (must be in the correct Date | Description | Credit | Debit format), manually set categories for
    transactions and save them all to a local database.</p>            
    <p> * View all transactions saved to the database or set a date range to view by. Update the category of individual transactions or delete unwanted
    transactions. </p>
    <p> * View all categories save to the database, change the order of the categories to change their priority in auto-categorising transactions (once a
    'Tag' has been found in a transactions descrption it returns its corresponding category and no further 'Tags' are checked for). Delete unwanted
    categories. </p>
    <p> * Values on landing page update whenever new data is added or removed from the database. </p>
    <p> * Select date range to display data for on the categories graph. </p>
    <p> * Select specific year to display data for on the year graph. </p>
</div>      
<div>
  <h4> Future Features </h4>
  <p> * Add Exact figures below graphs </p>
  <p> * Add sub-categories - to be added to each category (Utilites could have Water|Electricy|Mobile|Internet ect) and allow the user to view the break
  down of each categories sub-categories on the categories graph. </p>
  <p> * Add net worth and debt trackers so users can view their change over time. </p>            
  <p> * Add investing form for users to calculate years to retirement given an expected networth at retirement, yearly returns from investments and
  current income minus expenses. </p>
</div>
