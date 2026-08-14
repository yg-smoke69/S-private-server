using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200044E")]
public class ForceTutorialNavigator : MonoBehaviour
{
	[Token(Token = "0x4003C6B")]
	[FieldOffset(Offset = "0xC")]
	protected bool m_ShowNavigator;

	[Token(Token = "0x4003C6C")]
	[FieldOffset(Offset = "0x10")]
	public GameObject EffectNode;

	[Token(Token = "0x4003C6D")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 m_ToPos;

	[Token(Token = "0x4003C6E")]
	[FieldOffset(Offset = "0x20")]
	private readonly float OFFSET;

	[Token(Token = "0x4003C6F")]
	[FieldOffset(Offset = "0x24")]
	private List<Transform> m_TrArrows;

	[Token(Token = "0x170001DD")]
	protected bool ShowNavigator
	{
		[Token(Token = "0x6001589")]
		[Address(RVA = "0xDEE2E0", Offset = "0xDEE2E0", VA = "0xDEE2E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600158A")]
		[Address(RVA = "0xDEE338", Offset = "0xDEE338", VA = "0xDEE338")]
		set
		{
		}
	}

	[Token(Token = "0x6001588")]
	[Address(RVA = "0xDEE248", Offset = "0xDEE248", VA = "0xDEE248")]
	public ForceTutorialNavigator()
	{
	}

	[Token(Token = "0x600158B")]
	[Address(RVA = "0xDEE3B8", Offset = "0xDEE3B8", VA = "0xDEE3B8")]
	private void OnShowGrenadeLineChanged()
	{
	}

	[Token(Token = "0x600158C")]
	[Address(RVA = "0xDEE6E0", Offset = "0xDEE6E0", VA = "0xDEE6E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600158D")]
	[Address(RVA = "0xDEE81C", Offset = "0xDEE81C", VA = "0xDEE81C")]
	private void Destroy()
	{
	}

	[Token(Token = "0x600158E")]
	[Address(RVA = "0xDEE944", Offset = "0xDEE944", VA = "0xDEE944")]
	private void Update()
	{
	}

	[Token(Token = "0x600158F")]
	[Address(RVA = "0xDEEA9C", Offset = "0xDEEA9C", VA = "0xDEEA9C")]
	private void DrawLine(Vector3 fromPos, Vector3 toPos)
	{
	}

	[Token(Token = "0x6001590")]
	[Address(RVA = "0xDEE4E4", Offset = "0xDEE4E4", VA = "0xDEE4E4")]
	private void DestroyTrArrows()
	{
	}

	[Token(Token = "0x6001591")]
	[Address(RVA = "0xDEF270", Offset = "0xDEF270", VA = "0xDEF270")]
	private void OnNavigatorChange(object[] data)
	{
	}
}
