using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BB8")]
public class BE_SlotSpot : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4006273")]
	[FieldOffset(Offset = "0xC")]
	private Transform FFOKIJCMHMM;

	[Token(Token = "0x4006274")]
	[FieldOffset(Offset = "0x10")]
	public BE_BlockSectionHeader_Slot BelongSlot;

	[Token(Token = "0x4006275")]
	[FieldOffset(Offset = "0x14")]
	public CABKKILKHNJ m_Type;

	[Token(Token = "0x4006276")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_HighLightPos;

	[Token(Token = "0x1700073F")]
	public Transform AAPOHEDPNDG
	{
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x12D71A0", Offset = "0x12D71A0", VA = "0x12D71A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000740")]
	public Vector2 KNNEHMMMMLI
	{
		[Token(Token = "0x60058F3")]
		[Address(RVA = "0x12D71F8", Offset = "0x12D71F8", VA = "0x12D71F8", Slot = "5")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000741")]
	public CABKKILKHNJ HMEBLIODHEO
	{
		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x12D7310", Offset = "0x12D7310", VA = "0x12D7310", Slot = "6")]
		get
		{
			return default(CABKKILKHNJ);
		}
	}

	[Token(Token = "0x17000742")]
	public Transform PPCIDFMHAAN
	{
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x12D7368", Offset = "0x12D7368", VA = "0x12D7368", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60058F1")]
	[Address(RVA = "0x12D7198", Offset = "0x12D7198", VA = "0x12D7198")]
	public BE_SlotSpot()
	{
	}

	[Token(Token = "0x60058F6")]
	[Address(RVA = "0x12D73C0", Offset = "0x12D73C0", VA = "0x12D73C0")]
	private void Awake()
	{
	}
}
