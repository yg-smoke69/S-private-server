using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D11")]
internal class VehicleCollision : MonoBehaviour
{
	[Token(Token = "0x4006A0B")]
	[FieldOffset(Offset = "0xC")]
	public Vehicle attachVehicle;

	[Token(Token = "0x4006A0C")]
	[FieldOffset(Offset = "0x10")]
	public bool isKillCollision;

	[Token(Token = "0x4006A0D")]
	[FieldOffset(Offset = "0x14")]
	private HashSet<Collider> PPKGBGANGEK;

	[Token(Token = "0x4006A0E")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 ODLNBLDPIEG;

	[Token(Token = "0x6006445")]
	[Address(RVA = "0x26E5EF0", Offset = "0x26E5EF0", VA = "0x26E5EF0")]
	public VehicleCollision()
	{
	}

	[Token(Token = "0x6006446")]
	[Address(RVA = "0x26E5FD0", Offset = "0x26E5FD0", VA = "0x26E5FD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006447")]
	[Address(RVA = "0x26E60FC", Offset = "0x26E60FC", VA = "0x26E60FC")]
	public void OnTriggerEnter(Collider KODGAANKJBG)
	{
	}

	[Token(Token = "0x6006448")]
	[Address(RVA = "0x26E66E4", Offset = "0x26E66E4", VA = "0x26E66E4")]
	public void OnTriggerExit(Collider KODGAANKJBG)
	{
	}
}
