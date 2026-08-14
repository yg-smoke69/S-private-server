using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A5A")]
public class GhostShadowRoot : MonoBehaviour
{
	[Token(Token = "0x2000A5B")]
	public delegate void onEffectFinsih();

	[Token(Token = "0x4005BD5")]
	[FieldOffset(Offset = "0xC")]
	public onEffectFinsih OnEffectFinish;

	[Token(Token = "0x4005BD6")]
	[FieldOffset(Offset = "0x10")]
	public List<GhostShadowEffect> GhostEffectList;

	[Token(Token = "0x4005BD7")]
	[FieldOffset(Offset = "0x14")]
	public float EndTime;

	[Token(Token = "0x4005BD8")]
	[FieldOffset(Offset = "0x18")]
	private bool bActive;

	[Token(Token = "0x17000636")]
	public bool IsActive
	{
		[Token(Token = "0x6005047")]
		[Address(RVA = "0x35043EC", Offset = "0x35043EC", VA = "0x35043EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005046")]
	[Address(RVA = "0x3504360", Offset = "0x3504360", VA = "0x3504360")]
	public GhostShadowRoot()
	{
	}

	[Token(Token = "0x6005048")]
	[Address(RVA = "0x3504178", Offset = "0x3504178", VA = "0x3504178")]
	public void Active(float endTime)
	{
	}

	[Token(Token = "0x6005049")]
	[Address(RVA = "0x35043F4", Offset = "0x35043F4", VA = "0x35043F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600504A")]
	[Address(RVA = "0x35042FC", Offset = "0x35042FC", VA = "0x35042FC")]
	public void DisActive()
	{
	}
}
