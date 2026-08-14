using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002484")]
public class UIHUDUGC_TwoTeamMatchInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E27D")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_TwoTeamMatchInfoView m_View;

	[Token(Token = "0x400E27E")]
	[FieldOffset(Offset = "0x2C")]
	private TwoTeamMatchInfoHudEntity m_ViewData;

	[Token(Token = "0x400E27F")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x400E280")]
	[FieldOffset(Offset = "0x34")]
	private Color Blue;

	[Token(Token = "0x400E281")]
	[FieldOffset(Offset = "0x44")]
	private Color Red;

	[Token(Token = "0x600D06B")]
	[Address(RVA = "0x292B410", Offset = "0x292B410", VA = "0x292B410")]
	public UIHUDUGC_TwoTeamMatchInfoController()
	{
	}

	[Token(Token = "0x600D06C")]
	[Address(RVA = "0x292B528", Offset = "0x292B528", VA = "0x292B528")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D06D")]
	[Address(RVA = "0x292B5CC", Offset = "0x292B5CC", VA = "0x292B5CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D06E")]
	[Address(RVA = "0x292B688", Offset = "0x292B688", VA = "0x292B688", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D06F")]
	[Address(RVA = "0x292B768", Offset = "0x292B768", VA = "0x292B768", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600D070")]
	[Address(RVA = "0x292B6F4", Offset = "0x292B6F4", VA = "0x292B6F4", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600D071")]
	[Address(RVA = "0x292BB68", Offset = "0x292BB68", VA = "0x292BB68")]
	private void ShowTeammateState(UIGrid grid, int alive, int dead, int knockDown, int flag)
	{
	}

	[Token(Token = "0x600D072")]
	[Address(RVA = "0x292C0E8", Offset = "0x292C0E8", VA = "0x292C0E8")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D073")]
	[Address(RVA = "0x292C170", Offset = "0x292C170", VA = "0x292C170")]
	private void OnShowTeamScoreChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D074")]
	[Address(RVA = "0x292C298", Offset = "0x292C298", VA = "0x292C298")]
	private void OnLeftTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D075")]
	[Address(RVA = "0x292C35C", Offset = "0x292C35C", VA = "0x292C35C")]
	private void OnRightTeamScoreChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D076")]
	[Address(RVA = "0x292C420", Offset = "0x292C420", VA = "0x292C420")]
	private void OnShowTeammateStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D077")]
	[Address(RVA = "0x292C5B8", Offset = "0x292C5B8", VA = "0x292C5B8")]
	private void OnLeftTeammateStateArrayChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600D078")]
	[Address(RVA = "0x292C84C", Offset = "0x292C84C", VA = "0x292C84C")]
	private void OnRightTeammateStateArrayChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600D079")]
	[Address(RVA = "0x292CAE0", Offset = "0x292CAE0", VA = "0x292CAE0")]
	private void OnLeftTeammateFlagCountChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D07A")]
	[Address(RVA = "0x292CB88", Offset = "0x292CB88", VA = "0x292CB88")]
	private void OnRightTeammateFlagCountChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D07B")]
	[Address(RVA = "0x292CC30", Offset = "0x292CC30", VA = "0x292CC30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D07C")]
	[Address(RVA = "0x292CC38", Offset = "0x292CC38", VA = "0x292CC38")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
