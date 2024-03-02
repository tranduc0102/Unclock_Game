using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed;
    public Animator anim;

    private float checkTraiPhai = 0;
    private float checkDiChuyen = 0;


    private void Update()
    {
        AnimationAndMove();
        if (checkDiChuyen == 1)
        {
            var position = transform.position;
            PoolingManager.Instance.GetObject(NamePrefabPool.PhuKienDiChuyen, position: new Vector3(position.x,position.y - 0.15f,0f)).Disable(0.1f);
            checkDiChuyen = 0;
        }
    }

    
    
    
    
    void AnimationAndMove()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("PhiaTrenDungYen" , 0);
            anim.SetFloat("TraiPhaiDungYen", 1);
            checkTraiPhai = 1;
        }
        else
        {
            checkTraiPhai = 0;
            anim.SetFloat("DiChuyenTraiPhai", 0);
            if (Input.GetKey(KeyCode.L))
            {
                anim.SetFloat("ChemTraiPhai",1);
            }
            else
            {
                anim.SetFloat("ChemTraiPhai",0);
            }
        }

        if (checkTraiPhai != 0)
        {
            if (Input.GetKey(KeyCode.D))
            {
                anim.SetFloat("DiChuyenTraiPhai", 1);
                transform.localScale = new Vector3(1, 1, 0);
                checkDiChuyen = 1;
                transform.position += new Vector3(0.2f,0,0) * (speed * Time.deltaTime);
                
                if (Input.GetKey(KeyCode.L))
                {
                    anim.SetFloat("ChemTraiPhai",1);
                }
                else
                {
                    anim.SetFloat("ChemTraiPhai",0);
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.SetFloat("DiChuyenTraiPhai", 1);
                transform.localScale = new Vector3(-1, 1, 0);
                checkDiChuyen = 1;
                transform.position += new Vector3(-0.2f,0,0) * (speed * Time.deltaTime);
                
                if (Input.GetKey(KeyCode.L))
                {
                    anim.SetFloat("ChemTraiPhai",1);
                }
                else
                {
                    anim.SetFloat("ChemTraiPhai",0);
                }
            }
        }
        
        
        
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("TraiPhaiDungYen", 0);
            anim.SetFloat("PhiaTrenDungYen" , 1);
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetFloat("DiChuyenDangSau", 1);
                checkDiChuyen = 1;
                transform.position += new Vector3(0,0.2f,0) * (speed * Time.deltaTime);
                if (Input.GetKey(KeyCode.L))
                {
                    anim.SetFloat("ChemSau",1);
                }
                else
                {
                    anim.SetFloat("ChemSau",0);
                }
            }
        }
        else
        {
            anim.SetFloat("DiChuyenDangSau", 0);
            if (Input.GetKey(KeyCode.L))
            {
                anim.SetFloat("ChemSau",1);
            }
            else
            {
                anim.SetFloat("ChemSau",0);
            }
        }
        
       if(Input.GetKey(KeyCode.S))
        {
            anim.SetFloat("TraiPhaiDungYen", 0);
            anim.SetFloat("PhiaTrenDungYen" , 0);
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                anim.SetFloat("DiChuyenPhiaTruoc", 1);
                checkDiChuyen = 1;
                transform.position += new Vector3(0,-0.2f,0) * (speed * Time.deltaTime);
                if (Input.GetKey(KeyCode.L))
                {
                    anim.SetFloat("ChemPhiaTruoc",1);
                }
                else
                {
                    anim.SetFloat("ChemPhiaTruoc",0);
                }
            }
        }
       else
       {
           anim.SetFloat("DiChuyenPhiaTruoc", 0);
           if (Input.GetKey(KeyCode.L))
           {
               anim.SetFloat("ChemPhiaTruoc",1);
           }
           else
           {
               anim.SetFloat("ChemPhiaTruoc",0);
           }
       }
    }
}
