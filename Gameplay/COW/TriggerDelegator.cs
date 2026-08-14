using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200080A")]
public class TriggerDelegator : MonoBehaviour
{
	[Token(Token = "0x40050AB")]
	[FieldOffset(Offset = "0xC")]
	public IOnTriggerEnterExit TriggerEnterTarget;

	[Token(Token = "0x40050AC")]
	[FieldOffset(Offset = "0x10")]
	public Action<Collider> OnEnter;

	[Token(Token = "0x40050AD")]
	[FieldOffset(Offset = "0x14")]
	public Action<Collider> OnExit;

	[Token(Token = "0x6003349")]
	[Address(RVA = "0x232F59C", Offset = "0x232F59C", VA = "0x232F59C")]
	public TriggerDelegator()
	{
	}

	[Token(Token = "0x600334A")]
	[Address(RVA = "0x232F5A4", Offset = "0x232F5A4", VA = "0x232F5A4", Slot = "4")]
	protected virtual bool CheckCollider(Collider other)
	{
		return default(bool);
	}

	[Token(Token = "0x600334B")]
	[Address(RVA = "0x232F67C", Offset = "0x232F67C", VA = "0x232F67C")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600334C")]
	[Address(RVA = "0x232F714", Offset = "0x232F714", VA = "0x232F714")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600334D")]
	[Address(RVA = "0x232F7AC", Offset = "0x232F7AC", VA = "0x232F7AC", Slot = "5")]
	protected virtual void OnEnterTriggerChecked(Collider other)
	{
	}

	[Token(Token = "0x600334E")]
	[Address(RVA = "0x232F8F8", Offset = "0x232F8F8", VA = "0x232F8F8", Slot = "6")]
	protected virtual void OnExitTriggerChecked(Collider other)
	{
	}
}
