﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Block
{
	public virtual int board_x
	{
        get { return board_x; }
        set { board_x = value; }
	}

	public virtual Polyomino piece
	{
        get { return piece; }
        set { piece = value; }
    }

	public virtual int board_y
	{
        get { return board_y; }
        set { board_y = value; }
    }

	public virtual int draw_y
	{
        get { return draw_y; }
        set { draw_y = value; }
	}
	public virtual int draw_x
	{
        get { return draw_x; }
		set { draw_x = value; }
	}

	public virtual void Draw(Board boardState)
	{

	}
    //This is a comment for git purposes
	public virtual void UpdateLocation(int x, int y, Board boardState)
	{
        
	}

	public virtual void SetLocation(int x, int y)
	{
		throw new System.NotImplementedException();
	}

	public virtual bool CanMove(int x, int y)
	{
		throw new System.NotImplementedException();
	}

}

