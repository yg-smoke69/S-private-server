using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AE3")]
public class UIRoomDropListTemplateController : UIBaseController
{
	[Token(Token = "0x2002AE4")]
	public delegate List<PopMenuData> OnDropBtnClick();

	[Token(Token = "0x4010761")]
	[FieldOffset(Offset = "0x28")]
	private UIRoomDropListTemplateView m_View;

	[Token(Token = "0x4010762")]
	[FieldOffset(Offset = "0x2C")]
	private OnDropBtnClick m_OnDropBtnClickCallback;

	[Token(Token = "0x4010763")]
	[FieldOffset(Offset = "0x30")]
	private UIPopMenuSmallControler m_PopMenuSmallControler;

	[Token(Token = "0x4010764")]
	[FieldOffset(Offset = "0x34")]
	private int m_BaseDepth;

	[Token(Token = "0x601196D")]
	[Address(RVA = "0x23BD070", Offset = "0x23BD070", VA = "0x23BD070")]
	public UIRoomDropListTemplateController()
	{
	}

	[Token(Token = "0x601196E")]
	[Address(RVA = "0x23BD0F4", Offset = "0x23BD0F4", VA = "0x23BD0F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601196F")]
	[Address(RVA = "0x23BD198", Offset = "0x23BD198", VA = "0x23BD198", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011970")]
	[Address(RVA = "0x23BD2EC", Offset = "0x23BD2EC", VA = "0x23BD2EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011971")]
	[Address(RVA = "0x23BD358", Offset = "0x23BD358", VA = "0x23BD358")]
	public void SetDropListInfoAndDefault(string labelTxt, OnDropBtnClick callback, string text, float maxCnt = 4.5f)
	{
	}

	[Token(Token = "0x6011972")]
	[Address(RVA = "0x23BD620", Offset = "0x23BD620", VA = "0x23BD620")]
	public void SetDropListInfo(string labelTxt, OnDropBtnClick callback, float maxCnt = 4.5f, float popMenuOffset = 346f, int popMenuWidth = 220)
	{
	}

	[Token(Token = "0x6011973")]
	[Address(RVA = "0x23BDA8C", Offset = "0x23BDA8C", VA = "0x23BDA8C")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6011974")]
	[Address(RVA = "0x23BDB18", Offset = "0x23BDB18", VA = "0x23BDB18")]
	public void SetDropListDepth(int depth)
	{
	}

	[Token(Token = "0x6011975")]
	[Address(RVA = "0x23BDBA8", Offset = "0x23BDBA8", VA = "0x23BDBA8")]
	public void SetSelectedText(string txt)
	{
	}

	[Token(Token = "0x6011976")]
	protected override T OpenChildController<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x6011977")]
	[Address(RVA = "0x23BDD98", Offset = "0x23BDD98", VA = "0x23BDD98")]
	private void _003CSetDropListInfoAndDefault_003Em__0()
	{
	}

	[Token(Token = "0x6011978")]
	[Address(RVA = "0x23BE00C", Offset = "0x23BE00C", VA = "0x23BE00C")]
	private void _003CSetDropListInfo_003Em__1()
	{
	}

	[Token(Token = "0x6011979")]
	[Address(RVA = "0x23BE06C", Offset = "0x23BE06C", VA = "0x23BE06C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601197A")]
	[Address(RVA = "0x23BE074", Offset = "0x23BE074", VA = "0x23BE074")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
