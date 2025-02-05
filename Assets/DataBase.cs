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
            PlayerPrefs.SetInt(Studentname + "Name", age);
            PlayerPrefs.SetInt(Studentname + "Student Number", studentnumber);
            PlayerPrefs.SetString(Studentname + "Student Section", StudentSection);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("Student Date saved: " + Studentname);
        }
    }
    public void LoadStudnetData()
    {
        string studentName = Search.text;
        if (PlayerPrefs.HasKey(studentName + "Age")) 
        {
            int AGE = PlayerPrefs.GetInt(studentName + "Age");
            int studentNumber = PlayerPrefs.GetInt(studentName + "Name");
            string STUDENTsection = PlayerPrefs.GetString(studentName + "Student Section");
            resultText.text = $"Name: {studentName}\nAge: {AGE}\n SN: {studentNumber}\nSection: {STUDENTsection}m";
        }
        else
        {
            resultText.text = "Student Not Found";
        }
    }
}