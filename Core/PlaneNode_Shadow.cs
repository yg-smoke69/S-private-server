using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FA2")]
public class PlaneNode_Shadow : PlanarShadowNode
{
	[Token(Token = "0x2003FA3")]
	public delegate void PlaneStateChanged(PlaneNode_Shadow node);

	[Token(Token = "0x401ACEA")]
	[FieldOffset(Offset = "0xC")]
	private Transform m_transform;

	[Token(Token = "0x401ACEB")]
	[FieldOffset(Offset = "0x10")]
	private float altitude;

	[Token(Token = "0x401ACEC")]
	[FieldOffset(Offset = "0x14")]
	private float curError;

	[Token(Token = "0x401ACED")]
	[FieldOffset(Offset = "0x18")]
	public PlaneStateChanged OnPlaneNodeChanged;

	[Token(Token = "0x17001C49")]
	public Transform shadowPlaneTrans
	{
		[Token(Token = "0x6019E4B")]
		[Address(RVA = "0x1C7CD7C", Offset = "0x1C7CD7C", VA = "0x1C7CD7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019E4C")]
		[Address(RVA = "0x1C7CD98", Offset = "0x1C7CD98", VA = "0x1C7CD98")]
		set
		{
		}
	}

	[Token(Token = "0x6019E4A")]
	[Address(RVA = "0x1C7E30C", Offset = "0x1C7E30C", VA = "0x1C7E30C")]
	public PlaneNode_Shadow()
	{
	}

	[Token(Token = "0x6019E4D")]
	[Address(RVA = "0x1C7E314", Offset = "0x1C7E314", VA = "0x1C7E314")]
	private void Init()
	{
	}

	[Token(Token = "0x6019E4E")]
	[Address(RVA = "0x1C7E728", Offset = "0x1C7E728", VA = "0x1C7E728")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019E4F")]
	[Address(RVA = "0x1C7E7DC", Offset = "0x1C7E7DC", VA = "0x1C7E7DC", Slot = "7")]
	protected override void OnDestroy()
	{
	}
}
