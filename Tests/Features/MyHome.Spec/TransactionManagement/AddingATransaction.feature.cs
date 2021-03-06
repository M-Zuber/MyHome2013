// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyHome.Spec.TransactionManagement
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AddingATransactionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "AddingATransaction.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AddingATransaction", "\tIn order to keep track of my income and expenses\r\n\tI need to be able to add a tr" +
                    "ansaction", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "AddingATransaction")))
            {
                global::MyHome.Spec.TransactionManagement.AddingATransactionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AddingATransactionWithADateInThePast(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with a date in the past", null, exampleTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table1.AddRow(new string[] {
                        "Amount",
                        "20.5"});
            table1.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 7
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table1, "And ");
#line 12
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the transaction should be added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with a date in the past: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWithADateInThePast_AddExpense()
        {
#line 5
this.AddingATransactionWithADateInThePast("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with a date in the past: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWithADateInThePast_AddIncome()
        {
#line 5
this.AddingATransactionWithADateInThePast("addIncome", "income", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingATransactionWithADateInTheFuture(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with a date in the future", null, exampleTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "Date",
                        "3000-06-06"});
            table2.AddRow(new string[] {
                        "Amount",
                        "20.5"});
            table2.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 22
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table2, "And ");
#line 27
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the transaction should be added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with a date in the future: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWithADateInTheFuture_AddExpense()
        {
#line 20
this.AddingATransactionWithADateInTheFuture("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with a date in the future: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWithADateInTheFuture_AddIncome()
        {
#line 20
this.AddingATransactionWithADateInTheFuture("addIncome", "income", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingATransactionWithNoDate(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with no date", null, exampleTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "Date",
                        ""});
            table3.AddRow(new string[] {
                        "Amount",
                        "20.5"});
            table3.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 37
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table3, "And ");
#line 42
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("the transaction should be added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.And("the date is the current date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no date: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWithNoDate_AddExpense()
        {
#line 35
this.AddingATransactionWithNoDate("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no date: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWithNoDate_AddIncome()
        {
#line 35
this.AddingATransactionWithNoDate("addIncome", "income", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingATransactionWith0AsTheAmount(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with 0 as the amount", null, exampleTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 52
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table4.AddRow(new string[] {
                        "Amount",
                        "0"});
            table4.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 53
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table4, "And ");
#line 58
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("the transaction should be added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with 0 as the amount: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWith0AsTheAmount_AddExpense()
        {
#line 51
this.AddingATransactionWith0AsTheAmount("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with 0 as the amount: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWith0AsTheAmount_AddIncome()
        {
#line 51
this.AddingATransactionWith0AsTheAmount("addIncome", "income", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingATransactionWithNoComment(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with no comment", null, exampleTags);
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 67
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table5.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table5.AddRow(new string[] {
                        "Amount",
                        "0"});
            table5.AddRow(new string[] {
                        "Comment",
                        ""});
#line 68
 testRunner.And("the following transaction data with a category \'food\' and payment method \'cash\'", ((string)(null)), table5, "And ");
#line 73
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.Then("the transaction should be added to the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no comment: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWithNoComment_AddExpense()
        {
#line 66
this.AddingATransactionWithNoComment("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no comment: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWithNoComment_AddIncome()
        {
#line 66
this.AddingATransactionWithNoComment("addIncome", "income", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingATransactionWithNoCategory(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with no Category", null, exampleTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 82
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table6.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table6.AddRow(new string[] {
                        "Amount",
                        "12"});
            table6.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 83
 testRunner.And("the following transaction data with a category \'\' and payment method \'cash\'", ((string)(null)), table6, "And ");
#line 88
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.Then("the handler returns an error indicator - \'There must be a category selected\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no Category: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWithNoCategory_AddExpense()
        {
#line 81
this.AddingATransactionWithNoCategory("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no Category: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWithNoCategory_AddIncome()
        {
#line 81
this.AddingATransactionWithNoCategory("addIncome", "income", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddingATransactionWithNoMethod(string testName, string transactionType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding a Transaction with no method", null, exampleTags);
#line 96
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 97
 testRunner.Given(string.Format("The transaction type is \'{0}\'", transactionType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table7.AddRow(new string[] {
                        "Date",
                        "2015-06-06"});
            table7.AddRow(new string[] {
                        "Amount",
                        "12"});
            table7.AddRow(new string[] {
                        "Comment",
                        "Stuff"});
#line 98
 testRunner.And("the following transaction data with a category \'food\' and payment method \'\'", ((string)(null)), table7, "And ");
#line 103
 testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("the handler returns an error indicator - \'There must be a payment method selected" +
                    "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no method: addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addExpense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "expense")]
        public virtual void AddingATransactionWithNoMethod_AddExpense()
        {
#line 96
this.AddingATransactionWithNoMethod("addExpense", "expense", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding a Transaction with no method: addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AddingATransaction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "addIncome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:transactionType", "income")]
        public virtual void AddingATransactionWithNoMethod_AddIncome()
        {
#line 96
this.AddingATransactionWithNoMethod("addIncome", "income", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
