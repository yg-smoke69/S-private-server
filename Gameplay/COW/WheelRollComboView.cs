using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AB6")]
public class WheelRollComboView : MonoBehaviour
{
	[Token(Token = "0x4018F4E")]
	[FieldOffset(Offset = "0xC")]
	public Transform ShowRoot;

	[Token(Token = "0x4018F4F")]
	[FieldOffset(Offset = "0x10")]
	public GameObject NumberMesh0;

	[Token(Token = "0x4018F50")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NumberMesh1;

	[Token(Token = "0x4018F51")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NumberMesh2;

	[Token(Token = "0x4018F52")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject VFXGo;

	[Token(Token = "0x4018F53")]
	[FieldOffset(Offset = "0x20")]
	public List<Texture> NumberTextureConfigs;

	[Token(Token = "0x60173EB")]
	[Address(RVA = "0x21BA030", Offset = "0x21BA030", VA = "0x21BA030")]
	public WheelRollComboView()
	{
	}

	[Token(Token = "0x60173EC")]
	[Address(RVA = "0x21BA0BC", Offset = "0x21BA0BC", VA = "0x21BA0BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60173ED")]
	[Address(RVA = "0x21BA180", Offset = "0x21BA180", VA = "0x21BA180")]
	public void SetCombo(int combo)
	{
	}

	[Token(Token = "0x60173EE")]
	[Address(RVA = "0x21BA5C4", Offset = "0x21BA5C4", VA = "0x21BA5C4")]
	private void LateUpdate()
	{
	}
}
