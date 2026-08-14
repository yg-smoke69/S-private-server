using GCommon.CommandPattern;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.UGCHudEdit;

[Token(Token = "0x2002405")]
public class SetHudWidgetAnchorPositionCommand : Command
{
	[Token(Token = "0x400E085")]
	[FieldOffset(Offset = "0x10")]
	private UGCHudWidget m_Target;

	[Token(Token = "0x400E086")]
	[FieldOffset(Offset = "0x14")]
	private Vector2 m_AnchorPosition;

	[Token(Token = "0x400E087")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 m_LastAnchorPosition;

	[Token(Token = "0x600CB91")]
	[Address(RVA = "0x2344B00", Offset = "0x2344B00", VA = "0x2344B00")]
	public SetHudWidgetAnchorPositionCommand()
	{
	}

	[Token(Token = "0x600CB92")]
	[Address(RVA = "0x2344B08", Offset = "0x2344B08", VA = "0x2344B08")]
	public void Set(UGCHudWidget target, float anchorPositionX, float anchorPositionY)
	{
	}

	[Token(Token = "0x600CB93")]
	[Address(RVA = "0x2344B50", Offset = "0x2344B50", VA = "0x2344B50", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x600CB94")]
	[Address(RVA = "0x2344CC8", Offset = "0x2344CC8", VA = "0x2344CC8", Slot = "15")]
	public override void UnExecute()
	{
	}

	[Token(Token = "0x600CB95")]
	[Address(RVA = "0x2344E40", Offset = "0x2344E40", VA = "0x2344E40", Slot = "16")]
	public override void Clear()
	{
	}
}
