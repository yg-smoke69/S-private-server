using System;
using Il2CppDummyDll;
using XNode;

[Serializable]
[Token(Token = "0x20002C9")]
public class ECAPhaseDataNode : ECAPhaseBaseNode
{
	[Token(Token = "0x40032FA")]
	[FieldOffset(Offset = "0x2C")]
	public int Duration;

	[Token(Token = "0x40032FB")]
	[FieldOffset(Offset = "0x30")]
	private ECARoundDataNode m_ParentRoundNode;

	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x320435C", Offset = "0x320435C", VA = "0x320435C")]
	public ECAPhaseDataNode()
	{
	}

	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x3204364", Offset = "0x3204364", VA = "0x3204364", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x3204368", Offset = "0x3204368", VA = "0x3204368")]
	public bool HasParentRound()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x32043F4", Offset = "0x32043F4", VA = "0x32043F4")]
	public void SetParentRound(ECARoundDataNode round)
	{
	}

	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x32043FC", Offset = "0x32043FC", VA = "0x32043FC")]
	public ECARoundDataNode GetParentRound()
	{
		return null;
	}

	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x3204404", Offset = "0x3204404", VA = "0x3204404", Slot = "5")]
	public override object GetValue(NodePort port)
	{
		return null;
	}
}
