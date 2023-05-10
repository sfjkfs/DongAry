using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterStates
{
    Idle, 
    Run, 
    Attack, 
    Jump,
    Ladder,
    Die
}
public class GeneralAnimation : StatSystem
{
    protected CharacterStates nowState;
    //�ڷ�ƾ �й�� : ���°��� String ������ ��ȯ�Ͽ� �ڷ�ƾ�� �����ϰ� ����
    protected virtual void StateUpdate(CharacterStates newState)
    {
        StopCoroutine(nowState.ToString());
        nowState = newState;
        Debug.Log(nowState);
        StartCoroutine(nowState.ToString());
    }
    IEnumerator Idle()
    {
        while(true)
        {
            //yield return null : ���� �����ӿ� ������ �簳�Ѵ�.
            //yield return new WaitForSeconds : ������ �ð� �Ŀ� �簳�Ѵ�.
            //yield return new WaitForSecondsRealtime :  Time.timescale ���� ������ ���� �ʰ� ������ �ð� �Ŀ� �簳�Ѵ�.
            //yield return new WaitForFixedUpdate : ��� ��ũ��Ʈ���� ��� FixedUpdate�� ȣ��� �Ŀ� �簳�Ѵ�.
            //yield return new WaitForEndOfFrame : ��� ī�޶�� GUI�� �������� �Ϸ��ϰ�, ��ũ���� �������� ǥ���ϱ� ���� ȣ��ȴ�.
            //yield return StartCoroutine() : �ڷ�ƾ�� �����ϰ� �ڷ�ƾ�� �Ϸ�� �Ŀ� �簳�Ѵ�.
            yield return null;
        }
    }
    IEnumerator Run()
    {
        while(true)
        {
            yield return null;
        }
    }
    IEnumerator Attack()
    {
        while(true)
        {
            yield return null;
        }
    }
IEnumerator Ladder()
    {
        while (true)
        {
            yield return null;
        }
    }
    IEnumerator Jump()
    {
        while(true)
        {
            yield return null;
        }
    }
    IEnumerator Die()
    {
        while(true)
        {
            yield return null;
        }
    }
}