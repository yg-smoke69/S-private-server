using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XNode;

[Serializable]
[Token(Token = "0x20002CA")]
public class ECARoundDataNode : ECAPhaseBaseNode
{
	[Token(Token = "0x40032FC")]
	[FieldOffset(Offset = "0x2C")]
	public uint RoundMaxNum;

	[Token(Token = "0x40032FD")]
	[FieldOffset(Offset = "0x30")]
	private List<ECAPhaseDataNode> PhaseData;

	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x3204408", Offset = "0x3204408", VA = "0x3204408")]
	public ECARoundDataNode()
	{
	}

	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x3204494", Offset = "0x3204494", VA = "0x3204494", Slot = "4")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x3204498", Offset = "0x3204498", VA = "0x3204498")]
	public void AddPhase(ECAPhaseDataNode phase)
	{
	}

	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x3204518", Offset = "0x3204518", VA = "0x3204518")]
	public void DeletePhase(int index)
	{
	}

	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x3204634", Offset = "0x3204634", VA = "0x3204634")]
	public void DeletePhase(ECAPhaseDataNode phase)
	{
	}

	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x3204718", Offset = "0x3204718", VA = "0x3204718")]
	public List<ECAPhaseDataNode> GetPhaseDataList()
	{
		return null;
	}

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x3204720", Offset = "0x3204720", VA = "0x3204720", Slot = "5")]
	public override object GetValue(NodePort port)
	{
		return null;
	}
}
