using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F4A")]
public class UIGuideNodeList
{
	[Token(Token = "0x400C4B2")]
	[FieldOffset(Offset = "0x8")]
	protected List<UIGuideNode> m_GuideNodeList;

	[Token(Token = "0x400C4B3")]
	[FieldOffset(Offset = "0xC")]
	private bool m_Ready;

	[Token(Token = "0x400C4B4")]
	[FieldOffset(Offset = "0xD")]
	private bool m_Processing;

	[Token(Token = "0x400C4B5")]
	[FieldOffset(Offset = "0x10")]
	private int m_Progress;

	[Token(Token = "0x400C4B6")]
	[FieldOffset(Offset = "0x14")]
	private string m_PlayerPrefKey;

	[Token(Token = "0x6009A99")]
	[Address(RVA = "0x20274E0", Offset = "0x20274E0", VA = "0x20274E0")]
	public UIGuideNodeList()
	{
	}

	[Token(Token = "0x6009A9A")]
	[Address(RVA = "0x20274E8", Offset = "0x20274E8", VA = "0x20274E8")]
	public bool IsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6009A9B")]
	[Address(RVA = "0x20275B4", Offset = "0x20275B4", VA = "0x20275B4")]
	public void Init(string playerPrefKey, List<UIGuideNode> guideNodeList)
	{
	}

	[Token(Token = "0x6009A9C")]
	[Address(RVA = "0x202777C", Offset = "0x202777C", VA = "0x202777C")]
	public void FinishNode(int index)
	{
	}

	[Token(Token = "0x6009A9D")]
	[Address(RVA = "0x2027880", Offset = "0x2027880", VA = "0x2027880", Slot = "4")]
	protected virtual void OnFinished()
	{
	}

	[Token(Token = "0x6009A9E")]
	[Address(RVA = "0x20278D4", Offset = "0x20278D4", VA = "0x20278D4")]
	public void Update()
	{
	}
}
