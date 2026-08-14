using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FD")]
public class LevelContainerLocationPreserver : MonoBehaviour
{
	[Token(Token = "0x4004528")]
	private const string RelatedShaderName1 = "BRMobile/Special/PickupDiffuse";

	[Token(Token = "0x4004529")]
	private const string RelatedShaderName2 = "BRMobile/Special/PickupCutOff";

	[Token(Token = "0x400452A")]
	private const string PropertyName = "_OriginPostion";

	[Token(Token = "0x400452B")]
	[FieldOffset(Offset = "0xC")]
	private Vector4 m_Postion;

	[Token(Token = "0x400452C")]
	[FieldOffset(Offset = "0x1C")]
	private List<Material> m_Materials;

	[Token(Token = "0x400452D")]
	[FieldOffset(Offset = "0x20")]
	private int m_PropertyHashID;

	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x3112E7C", Offset = "0x3112E7C", VA = "0x3112E7C")]
	public LevelContainerLocationPreserver()
	{
	}

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x3112E84", Offset = "0x3112E84", VA = "0x3112E84")]
	private void Start()
	{
	}

	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x3113364", Offset = "0x3113364", VA = "0x3113364")]
	private void Update()
	{
	}
}
