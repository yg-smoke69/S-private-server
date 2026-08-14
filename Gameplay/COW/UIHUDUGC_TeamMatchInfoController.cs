using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200247B")]
public class UIHUDUGC_TeamMatchInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E256")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_TeamMatchInfoView m_View;

	[Token(Token = "0x400E257")]
	[FieldOffset(Offset = "0x2C")]
	private TeamMatchInfoHudEntity m_ViewData;

	[Token(Token = "0x400E258")]
	[FieldOffset(Offset = "0x30")]
	private string m_EntityID;

	[Token(Token = "0x600CFF5")]
	[Address(RVA = "0x2922D58", Offset = "0x2922D58", VA = "0x2922D58")]
	public UIHUDUGC_TeamMatchInfoController()
	{
	}

	[Token(Token = "0x600CFF6")]
	[Address(RVA = "0x2922DDC", Offset = "0x2922DDC", VA = "0x2922DDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CFF7")]
	[Address(RVA = "0x2922E80", Offset = "0x2922E80", VA = "0x2922E80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CFF8")]
	[Address(RVA = "0x2922F3C", Offset = "0x2922F3C", VA = "0x2922F3C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CFF9")]
	[Address(RVA = "0x292301C", Offset = "0x292301C", VA = "0x292301C", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CFFA")]
	[Address(RVA = "0x2922FA8", Offset = "0x2922FA8", VA = "0x2922FA8", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CFFB")]
	[Address(RVA = "0x29233C0", Offset = "0x29233C0", VA = "0x29233C0")]
	private string GetText(string key, object[] param)
	{
		return null;
	}

	[Token(Token = "0x600CFFC")]
	[Address(RVA = "0x292373C", Offset = "0x292373C", VA = "0x292373C")]
	private void ShowScore()
	{
	}

	[Token(Token = "0x600CFFD")]
	[Address(RVA = "0x29238D4", Offset = "0x29238D4", VA = "0x29238D4")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CFFE")]
	[Address(RVA = "0x292395C", Offset = "0x292395C", VA = "0x292395C")]
	private void OnOffsetPositionChanged(Vector3 old, Vector3 cur)
	{
	}

	[Token(Token = "0x600CFFF")]
	[Address(RVA = "0x2923B24", Offset = "0x2923B24", VA = "0x2923B24")]
	private void OnRankChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D000")]
	[Address(RVA = "0x2923C7C", Offset = "0x2923C7C", VA = "0x2923C7C")]
	private void OnTeamColorChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600D001")]
	[Address(RVA = "0x2923D5C", Offset = "0x2923D5C", VA = "0x2923D5C")]
	private void OnIconSpriteNameChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D002")]
	[Address(RVA = "0x2923ECC", Offset = "0x2923ECC", VA = "0x2923ECC")]
	private void OnShowFrameChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600D003")]
	[Address(RVA = "0x2923F7C", Offset = "0x2923F7C", VA = "0x2923F7C")]
	private void OnScoreTextKey_ParamsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600D004")]
	[Address(RVA = "0x2923FFC", Offset = "0x2923FFC", VA = "0x2923FFC")]
	private void OnScoreTextKeyChanged(string old, string cur)
	{
	}

	[Token(Token = "0x600D005")]
	[Address(RVA = "0x292407C", Offset = "0x292407C", VA = "0x292407C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D006")]
	[Address(RVA = "0x2924084", Offset = "0x2924084", VA = "0x2924084")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
