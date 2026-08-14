using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200072A")]
internal class UGCLevelCustomPath : BaseLevelObject
{
	[Token(Token = "0x4004C4A")]
	[FieldOffset(Offset = "0x74")]
	public LineRenderer lineRender;

	[Token(Token = "0x4004C4B")]
	[FieldOffset(Offset = "0x78")]
	public GameObject StartPointObj;

	[Token(Token = "0x4004C4C")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject EndPointObj;

	[Token(Token = "0x4004C4D")]
	[FieldOffset(Offset = "0x80")]
	public GameObject StartPointModel;

	[Token(Token = "0x4004C4E")]
	[FieldOffset(Offset = "0x84")]
	public GameObject EndPointModel;

	[Token(Token = "0x4004C4F")]
	[FieldOffset(Offset = "0x88")]
	public GameObject ControlPointTemplate;

	[Token(Token = "0x4004C50")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject ControlPointRoot;

	[Token(Token = "0x4004C51")]
	[FieldOffset(Offset = "0x90")]
	private JPPGAJBAAKK MNBJHAFLMIH;

	[Token(Token = "0x4004C52")]
	[FieldOffset(Offset = "0x94")]
	private SceneEditObjectCustomPath AOBALOEMGMJ;

	[Token(Token = "0x4004C53")]
	[FieldOffset(Offset = "0x98")]
	private bool HMEADDLIGCF;

	[Token(Token = "0x4004C54")]
	[FieldOffset(Offset = "0x9C")]
	private ResourceID FMEHFOGLPDI;

	[Token(Token = "0x4004C55")]
	[FieldOffset(Offset = "0xA0")]
	private ResourceID AOAAOMKBMKL;

	[Token(Token = "0x4004C56")]
	[FieldOffset(Offset = "0xA4")]
	private string LACIKMOOCCN;

	[Token(Token = "0x4004C57")]
	[FieldOffset(Offset = "0xA8")]
	public List<SceneEditObjectCustomPoint> ControlPoints;

	[Token(Token = "0x4004C58")]
	[FieldOffset(Offset = "0xAC")]
	private SceneEditPrefabConfigData LBLLOGNJMKD;

	[Token(Token = "0x4004C59")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<SceneEditObjectCustomPoint> HMDOHFBHDOB;

	[Token(Token = "0x17000358")]
	public string GIKMAINHGGK
	{
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x1385D48", Offset = "0x1385D48", VA = "0x1385D48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x1385DA0", Offset = "0x1385DA0", VA = "0x1385DA0")]
		set
		{
		}
	}

	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x1385C44", Offset = "0x1385C44", VA = "0x1385C44")]
	public UGCLevelCustomPath()
	{
	}

	[Token(Token = "0x6002D35")]
	[Address(RVA = "0x1385F2C", Offset = "0x1385F2C", VA = "0x1385F2C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002D36")]
	[Address(RVA = "0x1385FD0", Offset = "0x1385FD0", VA = "0x1385FD0")]
	public void OnCreated()
	{
	}

	[Token(Token = "0x6002D37")]
	[Address(RVA = "0x1386300", Offset = "0x1386300", VA = "0x1386300")]
	public void SetControlPointsData(Vector3[] GGHBMEMIOCL)
	{
	}

	[Token(Token = "0x6002D38")]
	[Address(RVA = "0x13865A0", Offset = "0x13865A0", VA = "0x13865A0")]
	public SceneEditObjectBase AddControlPoint(Vector3 ACCOJJMKKPM)
	{
		return null;
	}

	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x1386AFC", Offset = "0x1386AFC", VA = "0x1386AFC")]
	public void AddPointNearPoint(SceneEditObjectAttrCustomPoint MMHEBMNOFIC)
	{
	}

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x1387094", Offset = "0x1387094", VA = "0x1387094")]
	public void OnRemoveSelf()
	{
	}

	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x13874D0", Offset = "0x13874D0", VA = "0x13874D0")]
	public bool IsFirstOrLastPoint(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x13875B8", Offset = "0x13875B8", VA = "0x13875B8")]
	public void RemovePointOfIndex(int HHLONFLCJBL)
	{
	}

	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0x1387834", Offset = "0x1387834", VA = "0x1387834")]
	public void OnRemovePoint(SceneEditObjectCustomPoint JBKIMCBCCMF, bool MMOHANJKPBG)
	{
	}

	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0x13878E0", Offset = "0x13878E0", VA = "0x13878E0")]
	public void UpdateControlPoint(int HHLONFLCJBL, SceneEditObjectCustomPoint ECINOMEHBKA, bool LNEMJMOFHCO)
	{
	}

	[Token(Token = "0x6002D3F")]
	[Address(RVA = "0x1387B60", Offset = "0x1387B60", VA = "0x1387B60")]
	public void SortPoint()
	{
	}

	[Token(Token = "0x6002D40")]
	[Address(RVA = "0x13866DC", Offset = "0x13866DC", VA = "0x13866DC")]
	public void UpdateLineRender(int FJLAIGFKBAA, Vector3 HFDALDBEKLO)
	{
	}

	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x1387CA0", Offset = "0x1387CA0", VA = "0x1387CA0")]
	public void UpdateLineRender(List<SceneEditCrosshair> IFMADOCDDND)
	{
	}

	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x1388260", Offset = "0x1388260", VA = "0x1388260")]
	public bool IsStartEndPoint(int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x1388348", Offset = "0x1388348", VA = "0x1388348")]
	private static int HGBECJPIACO(SceneEditObjectCustomPoint AAFBIANMEAL, SceneEditObjectCustomPoint KENDCFNPDCE)
	{
		return default(int);
	}
}
