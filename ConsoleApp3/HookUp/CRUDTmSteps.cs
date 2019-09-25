using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ConsoleApp3
{
    [Binding]
    public class CRUDTmSteps
    {
        

        [Given(@"I have login into time and material page")]
        public void GivenIHaveLoginIntoTimeAndMaterialPage()
        {
            HomePage homeInstance = new HomePage();
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdminstration();
            homeInstance.ClickTimenMaterial();
        }
        
        [Given(@"I have navigate to the time and material page")]
        public void GivenIHaveNavigateToTheTimeAndMaterialPage()
        {
            TimenMaterialPage tmPage = new TimenMaterialPage();
            tmPage.ClickCreateNew(driver);
            tmPage.EnterValidDataandSave(driver);
            
        }
        
        [Then(@"I should create time and material page successfully")]
        public void ThenIShouldCreateTimeAndMaterialPageSuccessfully()
        {
            TimenMaterialPage tmPage = new TimenMaterialPage();
            tmPage.ClickCreateNew(driver);
            tmPage.EnterValidDataandSave(driver);
            tmPage.ValidateData(driver);
        }
        
        [Then(@"I should be able to delete a time and material record\.")]
        public void ThenIShouldBeAbleToDeleteATimeAndMaterialRecord_()
        {
            TimenMaterialPage tmPage = new TimenMaterialPage();
            tmPage.ClickCreateNew(driver);
            tmPage.EnterValidDataandSave(driver);
            tmPage.ValidateData(driver);
        }
        
        [Then(@"I should be able to edit a time and material record\.")]
        public void ThenIShouldBeAbleToEditATimeAndMaterialRecord_()
        {
            TimenMaterialPage tmPage = new TimenMaterialPage();
            tmPage.ClickCreateNew(driver);
            tmPage.EnterValidDataandSave(driver);
            tmPage.ValidateData(driver); 
        }
    }
}
