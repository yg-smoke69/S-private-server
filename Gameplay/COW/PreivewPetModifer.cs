using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A20")]
public class PreivewPetModifer : MonoBehaviour
{
	[Token(Token = "0x4005AF6")]
	[FieldOffset(Offset = "0xC")]
	public float shopy;

	[Token(Token = "0x4005AF7")]
	[FieldOffset(Offset = "0x10")]
	public float commony;

	[Token(Token = "0x4005AF8")]
	[FieldOffset(Offset = "0x14")]
	public float elitepassy;

	[Token(Token = "0x4005AF9")]
	[FieldOffset(Offset = "0x18")]
	public float fullscreeny;

	[Token(Token = "0x4005AFA")]
	[FieldOffset(Offset = "0x1C")]
	public float bigmodey;

	[Token(Token = "0x4005AFB")]
	[FieldOffset(Offset = "0x20")]
	public float iapy;

	[Token(Token = "0x4005AFC")]
	[FieldOffset(Offset = "0x24")]
	public float fullScreenPreviewY;

	[Token(Token = "0x4005AFD")]
	[FieldOffset(Offset = "0x28")]
	public float paymenty;

	[Token(Token = "0x4005AFE")]
	[FieldOffset(Offset = "0x2C")]
	public float gachay;

	[Token(Token = "0x4005AFF")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 PreivewPetRotate;

	[Token(Token = "0x4005B00")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_Inited;

	[Token(Token = "0x4005B01")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, float> m_PreivewPetModiferDic;

	[Token(Token = "0x17000629")]
	public Dictionary<int, float> PreivewPetModiferDic
	{
		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0x1C0DF8C", Offset = "0x1C0DF8C", VA = "0x1C0DF8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F1A")]
	[Address(RVA = "0x1C0DF00", Offset = "0x1C0DF00", VA = "0x1C0DF00")]
	public PreivewPetModifer()
	{
	}
}
