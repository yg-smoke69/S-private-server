using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB6")]
public class Trail : TrailRenderer_Base
{
	[Token(Token = "0x401A7AC")]
	[FieldOffset(Offset = "0x20")]
	public Color MainColor;

	[Token(Token = "0x401A7AD")]
	[FieldOffset(Offset = "0x30")]
	public float MinVertexDistance;

	[Token(Token = "0x401A7AE")]
	[FieldOffset(Offset = "0x34")]
	public int MaxNumberOfPoints;

	[Token(Token = "0x401A7AF")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x401A7B0")]
	[FieldOffset(Offset = "0x44")]
	private float m_DistanceMoved;

	[Token(Token = "0x6019814")]
	[Address(RVA = "0x3240E60", Offset = "0x3240E60", VA = "0x3240E60")]
	public Trail()
	{
	}

	[Token(Token = "0x6019815")]
	[Address(RVA = "0x3240EB8", Offset = "0x3240EB8", VA = "0x3240EB8", Slot = "5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6019816")]
	[Address(RVA = "0x3240FA4", Offset = "0x3240FA4", VA = "0x3240FA4", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6019817")]
	[Address(RVA = "0x324117C", Offset = "0x324117C", VA = "0x324117C", Slot = "12")]
	protected override void Reset()
	{
	}

	[Token(Token = "0x6019818")]
	[Address(RVA = "0x324119C", Offset = "0x324119C", VA = "0x324119C", Slot = "9")]
	protected override void OnTranslate(Vector3 t)
	{
	}

	[Token(Token = "0x6019819")]
	[Address(RVA = "0x3241268", Offset = "0x3241268", VA = "0x3241268", Slot = "10")]
	protected override Color GetMainColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601981A")]
	[Address(RVA = "0x3241278", Offset = "0x3241278", VA = "0x3241278", Slot = "11")]
	protected override int GetMaxNumberOfPoints()
	{
		return default(int);
	}
}
