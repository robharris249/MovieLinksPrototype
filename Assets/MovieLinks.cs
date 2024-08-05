using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;

public class MovieLinks : MonoBehaviour {

    public GameObject BradPittPicture;
    public GameObject BradPittTitle;
    public GameObject BradPittGender;
    public GameObject BradPittBirthYear;
    public GameObject BradPittNationality;

    public GameObject JonahHillPicture;
    public GameObject JonahHillTitle;
    public GameObject JonahHillGender;
    public GameObject JonahHillBirthYear;
    public GameObject JonahHillNationality;

    public GameObject MoneyBallPicture;
    public GameObject MoneyBallTitle;
    public GameObject MoneyBallReleaseYear;
    public GameObject MoneyBallGenre;

    public GameObject Actor1Input;
    public GameObject Actor2Input;
    public GameObject MovieInput;

    public GameObject actor1Line;
    public GameObject actor2Line;
    public GameObject movieLine;

    private int Actor1GuessCount = 0;
    private int Actor2GuessCount = 0;
    private int MovieGuessCount = 0;

    private int actor1ScoreInt = 0;
    private int actor2ScoreInt = 0;
    private int movieScoreInt = 0;

    public GameObject actor1Score;
    public GameObject actor2Score;
    public GameObject movieScore;

    public GameObject totalScore;

    // Start is called before the first frame update
    void Start() {
        BradPittPicture.SetActive(false);
        BradPittTitle.SetActive(false);
        BradPittGender.SetActive(false);
        BradPittBirthYear.SetActive(false);
        BradPittNationality.SetActive(false);

        JonahHillPicture.SetActive(false);
        JonahHillTitle.SetActive(false);
        JonahHillGender.SetActive(false);
        JonahHillBirthYear.SetActive(false);
        JonahHillNationality.SetActive(false); 

        MoneyBallPicture.SetActive(false);
        MoneyBallTitle.SetActive(false);
        MoneyBallReleaseYear.SetActive(false);
        MoneyBallGenre.SetActive(false);

        actor1Line.SetActive(false);
        actor2Line.SetActive(false);
        movieLine.SetActive(false);
    }

    void Update() {

        if((!Actor1Input.activeSelf) && (!Actor2Input.activeSelf) && (!MovieInput.activeSelf)) {
            totalScore.GetComponent<TMP_Text>().text = (actor1ScoreInt + actor2ScoreInt + movieScoreInt) + " / 15";
        }
    }

    public void MakeGuess(string tag, string guess) {

        switch(tag) {

            case "ActorGuess1":
                if (guess == "Brad Pitt") {
                    showActor1();
                } else {
                    badGuessActor1();
                }
                break;

            case "ActorGuess2":
                if (guess == "Jonah Hill") {
                    showActor2();
                }
                else {
                    badGuessActor2();
                }
                break;

            case "FilmGuess1":
                if (guess == "Moneyball") {
                    showFilm1();
                }
                else {
                    badGuessFilm1();
                }
                break;

            default:
                Debug.Log("Error: unknown Tag");
                break;

        }
    }

    public void showActor1() {
        BradPittPicture.SetActive(true);
        BradPittTitle.SetActive(true);
        BradPittGender.SetActive(true);
        BradPittBirthYear.SetActive(true);
        BradPittNationality.SetActive(true);
        Actor1Input.SetActive(false);
        actor1Line.SetActive(true);

        actor1ScoreInt = (5 - Actor1GuessCount);

        actor1Score.GetComponent<TMP_Text>().text = actor1ScoreInt + " / 5";
    }

    public void badGuessActor1() {
        Actor1GuessCount++;

        switch(Actor1GuessCount) {
            case 1:
                BradPittGender.gameObject.GetComponent<TMP_Text>().color = Color.red;
                BradPittGender.SetActive(true);
                break;

            case 2: 
                BradPittBirthYear.gameObject.GetComponent<TMP_Text>().color = Color.red;
                BradPittBirthYear.SetActive(true);
                break;

            case 3:
                BradPittNationality.gameObject.GetComponent<TMP_Text>().color = Color.red;
                BradPittNationality.SetActive(true);
                break;

            case 4:
                BradPittPicture.SetActive(true);
                BradPittTitle.gameObject.GetComponent<TMP_Text>().color = Color.red;
                BradPittTitle.SetActive(true);
                Actor1Input.SetActive(false);

                actor1Score.GetComponent<TMP_Text>().color = Color.red;
                actor1Score.GetComponent<TMP_Text>().text = "" + 0;
                actor1ScoreInt = 0;
                actor1Line.SetActive(true);
                break;
        }
    }

    public void showActor2() {
        JonahHillPicture.SetActive(true);
        JonahHillTitle.SetActive(true);
        JonahHillGender.SetActive(true);
        JonahHillBirthYear.SetActive(true);
        JonahHillNationality.SetActive(true);
        Actor2Input.SetActive(false);
        actor2Line.SetActive(true);

        actor2ScoreInt = (5 - Actor2GuessCount);

        actor2Score.GetComponent<TMP_Text>().text = actor2ScoreInt + " / 5";
    }

    public void badGuessActor2() {
        Actor2GuessCount++;

        switch (Actor2GuessCount) {
            case 1:
                JonahHillGender.gameObject.GetComponent<TMP_Text>().color = Color.red;
                JonahHillGender.SetActive(true);
                break;

            case 2:
                JonahHillBirthYear.gameObject.GetComponent<TMP_Text>().color = Color.red;
                JonahHillBirthYear.SetActive(true);
                break;

            case 3:
                JonahHillNationality.gameObject.GetComponent<TMP_Text>().color = Color.red;
                JonahHillNationality.SetActive(true);
                break;

            case 4:
                JonahHillPicture.SetActive(true);
                JonahHillTitle.gameObject.GetComponent<TMP_Text>().color = Color.red;
                JonahHillTitle.SetActive(true);
                Actor2Input.SetActive(false);

                actor2Score.GetComponent<TMP_Text>().color = Color.red;
                actor2Score.GetComponent<TMP_Text>().text = "" + 0;
                actor2ScoreInt = 0;

                actor2Line.SetActive(true);
                break;
        }
    }

    public void showFilm1() {
        MoneyBallPicture.SetActive(true);
        MoneyBallTitle.SetActive(true);
        MoneyBallReleaseYear.SetActive(true);
        MoneyBallGenre.SetActive(true);
        MovieInput.SetActive(false);
        movieLine.SetActive(true);

        movieScoreInt = (5 - (MovieGuessCount * 2));

        movieScore.GetComponent<TMP_Text>().text = movieScoreInt + " / 5";
    }

    public void badGuessFilm1() {
        MovieGuessCount++;

        switch (MovieGuessCount) {
            case 1:
                MoneyBallReleaseYear.gameObject.GetComponent<TMP_Text>().color = Color.red;
                MoneyBallReleaseYear.SetActive(true);
                break;

            case 2:
                MoneyBallGenre.gameObject.GetComponent<TMP_Text>().color = Color.red;
                MoneyBallGenre.SetActive(true);
                break;

            case 3:
                MoneyBallPicture.SetActive(true);
                MoneyBallTitle.gameObject.GetComponent<TMP_Text>().color = Color.red;
                MoneyBallTitle.SetActive(true);
                MovieInput.SetActive(false);
                movieScore.GetComponent<TMP_Text>().color= Color.red;
                movieScore.GetComponent<TMP_Text>().text = "" + 0;
                movieScoreInt = 0;
                movieLine.SetActive(true);
                break;
        }
    }
}
