import { browser, by, element } from 'protractor';

export class AppHomePage {
    navigateTo() {
      return browser.get('/cannabislicensing/');
    }

    getMainHeading() {
      return element(by.css('app-root h1')).getText();
    }

    inputEmail() {
        return element(by.id("inputEmail"));
    }
    inputEmailButton() {
        return element(by.id("inputEmailButton"));
    }


    inputVoteButton(slug, number) {
      return element(by.id("vote_" + slug + "_" + number));
    }


    hasEmailRegistration() {
        return this.inputEmail().isPresent() && this.inputEmailButton().isPresent();
    }

    linkToSurvey() {
        return element(by.id("surveyStartButton"));
    }

    hasLinkToSurvey() {
        return this.linkToSurvey().isPresent();
    }

    hasVotingWidgets() {
        return element(by.id("showVoteResultsButton")).isPresent() || element(by.id("hideVoteResultsButton")).isPresent();
    }

    isVotingButtonsPresent(slug) {            
      return element(by.id("voteOptionButtons_" + slug)).isPresent();
    }
}

/*
var AppHomePage = function() {
    var inputEmail = element(by.id("inputEmail"));
    var inputEmailButton = element(by.id("inputEmailButton"));
    var surveyStartButton = element(by.id("surveyStartButton"));
    var showVoteResultsButton = element(by.id("showVoteResultsButton"));
    var hideVoteResultsButton = element(by.id("hideVoteResultsButton"));

    this.navigateTo = function() {
      return browser.get('/cannabislicensing/');
    };

    this.getMainHeading = function() {
      return element(by.css('app-root h1')).getText();
    };

    this.hasEmailRegistration = function() {
        return element(by.id("inputEmail")).isPresent() && element(by.id("inputEmailButton")).isPresent();
    };

    this.hasLinkToSurvey = function() {
        return element(by.id("surveyStartButton")).isPresent();
    };

    this.hasVotingWidgets = function() {
        return element(by.id("showVoteResultsButton")).isPresent() || element(by.id("hideVoteResultsButton")).isPresent();
    };
};
module.exports = new AppHomePage();
*/