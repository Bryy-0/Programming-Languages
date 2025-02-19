using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;

public class DataBase : MonoBehaviour
{
    public InputField Name;
    public InputField Age;
    public InputField StudentID;
    public InputField Section;
    public InputField Search;
    public Text resultText;

    public void SaveStudentData()
    {
        string Studentname = Name.text;
        int age, studentnumber;
        string StudentSection = Section.text;
        
        if (!string.IsNullOrEmpty(Studentname) &&
            int.TryParse(Age.text, out age) &&
            int.TryParse(StudentID.text, out studentnumber) &&
            !string.IsNullOrEmpty(StudentSection))
        {
            PlayerPrefs.SetString(Studentname + "Name", Studentname);
            PlayerPrefs.SetInt(Studentname + "Age", age);
            PlayerPrefs.SetInt(Studentname + "Student Number", studentnumber);
            PlayerPrefs.SetString(Studentname + "Student Section", StudentSection);
            PlayerPrefs.Save();
            Debug.Log("Student Date saved: " + Studentname);
        }
        else
        {
            Debug.Log("Student Not saved: " + Studentname);
        }
    }
    public void LoadStudentData()
    {
        string studentSearch = Search.text;
        if (PlayerPrefs.HasKey(studentSearch + "Name")) 
        {
            int Loadage = PlayerPrefs.GetInt(studentSearch + "Age");
            int LoadstudentNumber = PlayerPrefs.GetInt(studentSearch + "Student Number");
            string Loadsection = PlayerPrefs.GetString(studentSearch + "Student Section");
            resultText.text = $"Name: {studentSearch}\nAge: {Loadage}\n SN: {LoadstudentNumber}\nSection: {Loadsection}";
        }
        else
        {
            resultText.text = "Student Not Found";
        }
    }
}