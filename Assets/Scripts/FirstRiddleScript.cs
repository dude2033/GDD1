using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstRiddleScript : MonoBehaviour
{
    [SerializeField] Text DayText;
    [SerializeField] Text MonthText;
    [SerializeField] Text YearText;
    [SerializeField] Text ReminderText;
    private int DayNum = 1;
    private int MonthNum = 1;
    private int YearNum = 2000;


    public void AddDay()
    {
        DayNum += 1;
        if(DayNum < 1)
        {
            DayNum = 31;
        }
        else if(DayNum > 31)
        {
            DayNum = 1;
        }
        DayText.text = DayNum.ToString() + ".";
        MonthNum += 1;
        if (MonthNum < 1)
        {
            MonthNum = 12;
        }
        else if (MonthNum > 12)
        {
            MonthNum = 1;
        }
        MonthText.text = MonthNum.ToString() + ".";
        YearNum -= 1;
        if (YearNum < 1990)
        {
            YearNum = 2010;
        }
        else if (YearNum > 2010)
        {
            YearNum = 1990;
        }
        YearText.text = YearNum.ToString();
        CheckDate();
    }


    public void AddMonth()
    {
        DayNum += 1;
        if (DayNum < 1)
        {
            DayNum = 31;
        }
        else if (DayNum > 31)
        {
            DayNum = 1;
        }
        DayText.text = DayNum.ToString() + ".";
        MonthNum += 1;
        if (MonthNum < 1)
        {
            MonthNum = 12;
        }
        else if (MonthNum > 12)
        {
            MonthNum = 1;
        }
        MonthText.text = MonthNum.ToString() + ".";
        YearNum += 2;
        if (YearNum < 1990)
        {
            YearNum = 2010;
        }
        else if (YearNum > 2010)
        {
            YearNum = 1990;
        }
        YearText.text = YearNum.ToString();
        CheckDate();
    }


    public void AddYear()
    {
        DayNum -= 1;
        if (DayNum < 1)
        {
            DayNum = 31;
        }
        else if (DayNum > 31)
        {
            DayNum = 1;
        }
        DayText.text = DayNum.ToString() + ".";
        MonthNum -= 1;
        if (MonthNum < 1)
        {
            MonthNum = 12;
        }
        else if (MonthNum > 12)
        {
            MonthNum = 1;
        }
        MonthText.text = MonthNum.ToString() + ".";
        YearNum += 1;
        if (YearNum < 1990)
        {
            YearNum = 2010;
        }
        else if (YearNum > 2010)
        {
            YearNum = 1990;
        }
        YearText.text = YearNum.ToString();
        CheckDate();
    }



    public void SubDay()
    {
        DayNum -= 1;
        if (DayNum < 1)
        {
            DayNum = 31;
        }
        else if (DayNum > 31)
        {
            DayNum = 1;
        }
        DayText.text = DayNum.ToString() + ".";
        MonthNum -= 1;
        if (MonthNum < 1)
        {
            MonthNum = 12;
        }
        else if (MonthNum > 12)
        {
            MonthNum = 1;
        }
        MonthText.text = MonthNum.ToString() + ".";
        YearNum -= 2;
        if (YearNum < 1990)
        {
            YearNum = 2010;
        }
        else if (YearNum > 2010)
        {
            YearNum = 1990;
        }
        YearText.text = YearNum.ToString();
        CheckDate();
    }

    public void SubMonth()
    {
        DayNum += 1;
        if (DayNum < 1)
        {
            DayNum = 31;
        }
        else if (DayNum > 31)
        {
            DayNum = 1;
        }
        DayText.text = DayNum.ToString() + ".";
        MonthNum -= 1;
        if (MonthNum < 1)
        {
            MonthNum = 12;
        }
        else if (MonthNum > 12)
        {
            MonthNum = 1;
        }
        MonthText.text = MonthNum.ToString() + ".";
        YearNum += 1;
        if (YearNum < 1990)
        {
            YearNum = 2010;
        }
        else if (YearNum > 2010)
        {
            YearNum = 1990;
        }
        YearText.text = YearNum.ToString();
        CheckDate();
    }

    public void SubYear()
    {
        DayNum -= 2;
        if (DayNum < 1)
        {
            DayNum = 31;
        }
        else if (DayNum > 31)
        {
            DayNum = 1;
        }
        DayText.text = DayNum.ToString() + ".";
        MonthNum += 2;
        if (MonthNum < 1)
        {
            MonthNum = 12;
        }
        else if (MonthNum > 12)
        {
            MonthNum = 1;
        }
        MonthText.text = MonthNum.ToString() + ".";
        YearNum -= 1;
        if (YearNum < 1990)
        {
            YearNum = 2010;
        }
        else if (YearNum > 2010)
        {
            YearNum = 1990;
        }
        YearText.text = YearNum.ToString();
        CheckDate();
    }



    private void CheckDate()
    {
        if (DayNum == 3 && MonthNum == 6 && YearNum == 1992)
        {
            SceneManager.LoadScene("EndScene");
        }
    }


}
