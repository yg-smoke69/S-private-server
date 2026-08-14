using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000A80")]
public class QualityObjectSimple : MonoBehaviour
{
	[Token(Token = "0x4005C7E")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> HighObjects;

	[Token(Token = "0x4005C7F")]
	[FieldOffset(Offset = "0x10")]
	public List<Transform> LowObjects;

	[Token(Token = "0x4005C80")]
	[FieldOffset(Offset = "0x14")]
	public List<Transform> LowestObjects;

	[Token(Token = "0x60050F7")]
	[Address(RVA = "0x19F0A00", Offset = "0x19F0A00", VA = "0x19F0A00")]
	public QualityObjectSimple()
	{
	}

	[Token(Token = "0x60050F8")]
	[Address(RVA = "0x19F0ABC", Offset = "0x19F0ABC", VA = "0x19F0ABC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60050F9")]
	[Address(RVA = "0x19F0D2C", Offset = "0x19F0D2C", VA = "0x19F0D2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60050FA")]
	[Address(RVA = "0x19F0BF0", Offset = "0x19F0BF0", VA = "0x19F0BF0")]
	private void ABMOPCJLELM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60050FB")]
	[Address(RVA = "0x19F0E54", Offset = "0x19F0E54", VA = "0x19F0E54")]
	private void HJJOMPFMOFA(bool KDLKHBMNHLH, bool EOBAEAIIGIB, bool PDAJIIJMHJO)
	{
	}

	[Token(Token = "0x60050FC")]
	[Address(RVA = "0x19F13D8", Offset = "0x19F13D8", VA = "0x19F13D8")]
	public void ShowNodes(bool KDLKHBMNHLH, bool EOBAEAIIGIB, bool PDAJIIJMHJO)
	{
	}
}
