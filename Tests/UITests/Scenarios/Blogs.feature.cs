﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITests.Scenarios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class BlogsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Blogs.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Blogs", "\tAs a user I want to read and create blogs", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Blogs")))
            {
                UITests.Scenarios.BlogsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName"});
            table1.AddRow(new string[] {
                        "Thomas"});
            table1.AddRow(new string[] {
                        "Wiljag"});
#line 5
 testRunner.Given("The following accounts are created", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Content",
                        "Writer"});
            table2.AddRow(new string[] {
                        "Mijn eerste blog",
                        "Dit is mijn eerste blog!",
                        "Thomas"});
            table2.AddRow(new string[] {
                        "Advances in test automation",
                        "In de rdw-techdays van 2016 is er een showcase over een continuous delivery proje" +
                            "ct",
                        "Wiljag"});
#line 9
 testRunner.And("The following blogs are created", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Read a blog")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Blogs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("blogs")]
        public virtual void ReadABlog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Read a blog", new string[] {
                        "blogs"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 16
 testRunner.Given("I look at the \'blog\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Content",
                        "Writer"});
            table3.AddRow(new string[] {
                        "Mijn eerste blog",
                        "Dit is mijn eerste blog!",
                        "Thomas"});
            table3.AddRow(new string[] {
                        "Advances in test automation",
                        "In de rdw-techdays van 2016 is er een showcase over een continuous delivery proje" +
                            "ct",
                        "Wiljag"});
#line 17
 testRunner.Then("I see the following blogs", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When logged in I can create a blog")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Blogs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("blogs")]
        public virtual void WhenLoggedInICanCreateABlog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When logged in I can create a blog", new string[] {
                        "blogs"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 24
 testRunner.When("I login as \'Thomas\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Content"});
            table4.AddRow(new string[] {
                        "Mijn tweede blog",
                        "Dit is mijn tweede blog omdat de eerste zo goed lukte!"});
#line 25
 testRunner.And("I create the following blogs", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Content",
                        "Writer"});
            table5.AddRow(new string[] {
                        "Mijn tweede blog",
                        "Dit is mijn tweede blog omdat de eerste zo goed lukte!",
                        "Thomas"});
#line 28
 testRunner.Then("I see the following blogs", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When a user creates a blog other users can read it")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Blogs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("blogs")]
        public virtual void WhenAUserCreatesABlogOtherUsersCanReadIt()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a user creates a blog other users can read it", new string[] {
                        "blogs"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 34
 testRunner.When("I login as \'Thomas\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Content"});
            table6.AddRow(new string[] {
                        "ISKS 2016",
                        "Deze blog beschrijft details over de automated testing"});
#line 35
 testRunner.And("I create the following blogs", ((string)(null)), table6, "And ");
#line 38
 testRunner.And("I login as \'Wiljag\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I look at the \'blog\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "Content",
                        "Writer"});
            table7.AddRow(new string[] {
                        "ISKS 2016",
                        "Deze blog beschrijft details over de automated testing",
                        "Thomas"});
#line 40
 testRunner.Then("I see the following blogs", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
