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

public class RotateLeftVisitor
{
	public virtual Board board
	{
		get;
		set;
	}

	public virtual CanChangeLocalVisitor canChange
	{
		get;
		set;
	}

	public virtual void RotateLeftCall(Polyomino poly)
	{
		throw new System.NotImplementedException();
	}

	public virtual void IPiece(IPiece piece)
	{
		throw new System.NotImplementedException();
	}

	public RotateLeftVisitor(Board board, CanChangeLocalVisitor change)
	{
	}

	public virtual void OPiece(OPiece piece)
	{
		throw new System.NotImplementedException();
	}

	public virtual void LPiece(LPiece piece)
	{
		throw new System.NotImplementedException();
	}

	public virtual void SPiece(SPiece piece)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ZPiece(ZPiece piece)
	{
		throw new System.NotImplementedException();
	}

	public virtual void JPiece(JPiece piece)
	{
		throw new System.NotImplementedException();
	}

}

