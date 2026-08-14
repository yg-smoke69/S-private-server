using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002401")]
public class RecordCreateHudWidgetCommand : RecordCommand
{
	[Token(Token = "0x400E077")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E078")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_GameObject;

	[Token(Token = "0x400E079")]
	[FieldOffset(Offset = "0x18")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x600CB7A")]
	[Address(RVA = "0x2343CB8", Offset = "0x2343CB8", VA = "0x2343CB8")]
	public RecordCreateHudWidgetCommand()
	{
	}

	[Token(Token = "0x600CB7B")]
	[Address(RVA = "0x2343CC0", Offset = "0x2343CC0", VA = "0x2343CC0")]
	public void Set(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CB7C")]
	[Address(RVA = "0x2343D84", Offset = "0x2343D84", VA = "0x2343D84", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB7D")]
	[Address(RVA = "0x2343E5C", Offset = "0x2343E5C", VA = "0x2343E5C", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB7E")]
	[Address(RVA = "0x2343F58", Offset = "0x2343F58", VA = "0x2343F58", Slot = "16")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600CB7F")]
	[Address(RVA = "0x2344040", Offset = "0x2344040", VA = "0x2344040", Slot = "17")]
	public override void Record()
	{
	}
}
