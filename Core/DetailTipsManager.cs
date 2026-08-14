using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20020AD")]
public class DetailTipsManager : SingletonModule<DetailTipsManager>
{
	[Token(Token = "0x400CCB6")]
	[FieldOffset(Offset = "0xC")]
	private UIDetailTipsController m_CurrentTips;

	[Token(Token = "0x400CCB7")]
	[FieldOffset(Offset = "0x10")]
	private UIProfileLongTimeTipsController m_CurrentProfileTips;

	[Token(Token = "0x600A884")]
	[Address(RVA = "0x2322A60", Offset = "0x2322A60", VA = "0x2322A60")]
	public DetailTipsManager()
	{
	}

	[Token(Token = "0x600A885")]
	[Address(RVA = "0x2322AF0", Offset = "0x2322AF0", VA = "0x2322AF0")]
	public void OpenProfileTips(Vector3 itemPos, string msg)
	{
	}

	[Token(Token = "0x600A886")]
	[Address(RVA = "0x2322CB8", Offset = "0x2322CB8", VA = "0x2322CB8")]
	public void CloseProfileTips()
	{
	}

	[Token(Token = "0x600A887")]
	[Address(RVA = "0x2322D74", Offset = "0x2322D74", VA = "0x2322D74")]
	public void Open(string name, string descrip, Vector3 itemSize, Vector3 itemPos, Vector3 offsetPos, bool isTopLeftAnchor = true)
	{
	}

	[Token(Token = "0x600A888")]
	[Address(RVA = "0x2322E8C", Offset = "0x2322E8C", VA = "0x2322E8C")]
	public void Open(BaseItemInfo info, Vector3 itemSize, Vector3 itemPos, Vector3 offsetPos, bool isTopLeftAnchor = true)
	{
	}

	[Token(Token = "0x600A889")]
	[Address(RVA = "0x2322EB0", Offset = "0x2322EB0", VA = "0x2322EB0")]
	public void Open(BaseItemInfo info, Vector3 itemPos)
	{
	}

	[Token(Token = "0x600A88A")]
	[Address(RVA = "0x2322FC8", Offset = "0x2322FC8", VA = "0x2322FC8")]
	public void OpenHyper(BaseItemInfo info, Vector3 itemPos, uint hyper_level, uint hyper_experience, uint hyper_onelevel_experence)
	{
	}

	[Token(Token = "0x600A88B")]
	[Address(RVA = "0x2323110", Offset = "0x2323110", VA = "0x2323110")]
	public void Open(BaseItemInfo info, Vector3 itemPos, int depth)
	{
	}

	[Token(Token = "0x600A88C")]
	[Address(RVA = "0x2323228", Offset = "0x2323228", VA = "0x2323228")]
	public void Open(uint id, Vector3 itemPos)
	{
	}

	[Token(Token = "0x600A88D")]
	[Address(RVA = "0x2323340", Offset = "0x2323340", VA = "0x2323340")]
	public void Open(string name, string descrip, Vector3 itemPos)
	{
	}

	[Token(Token = "0x600A88E")]
	[Address(RVA = "0x2323460", Offset = "0x2323460", VA = "0x2323460")]
	public string GetTipsDescrption()
	{
		return null;
	}

	[Token(Token = "0x600A88F")]
	[Address(RVA = "0x2323560", Offset = "0x2323560", VA = "0x2323560")]
	public void CloseTips()
	{
	}

	[Token(Token = "0x600A890")]
	[Address(RVA = "0x232361C", Offset = "0x232361C", VA = "0x232361C")]
	public void Open(string name, string descrip, Vector3 itemPos, List<ResourceID> spriteResIds, bool needResize = false)
	{
	}

	[Token(Token = "0x600A891")]
	[Address(RVA = "0x2323740", Offset = "0x2323740", VA = "0x2323740")]
	public void Open(string name, string descrip, Vector3 itemPos, Vector3 offset)
	{
	}

	[Token(Token = "0x600A892")]
	[Address(RVA = "0x2323874", Offset = "0x2323874", VA = "0x2323874")]
	public void Open(string name, string descrip, Vector3 itemPos, Vector2 itemSize)
	{
	}

	[Token(Token = "0x600A893")]
	[Address(RVA = "0x2323A10", Offset = "0x2323A10", VA = "0x2323A10", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600A894")]
	[Address(RVA = "0x2323A14", Offset = "0x2323A14", VA = "0x2323A14", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
