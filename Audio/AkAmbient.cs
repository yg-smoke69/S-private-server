using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E0F")]
public class AkAmbient : AkEvent
{
	[Token(Token = "0x401A4AB")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<uint, AkMultiPosEvent> multiPosEventTree;

	[Token(Token = "0x401A4AC")]
	[FieldOffset(Offset = "0x4C")]
	public AkMultiPositionType MultiPositionType;

	[Token(Token = "0x401A4AD")]
	[FieldOffset(Offset = "0x50")]
	public MultiPositionTypeLabel multiPositionTypeLabel;

	[Token(Token = "0x401A4AE")]
	[FieldOffset(Offset = "0x54")]
	public AkAmbientLargeModePositioner[] LargeModePositions;

	[Token(Token = "0x401A4AF")]
	[FieldOffset(Offset = "0x58")]
	public byte AttenuationSphereOptions;

	[Token(Token = "0x401A4B0")]
	[FieldOffset(Offset = "0x5C")]
	public List<Vector3> multiPositionArray;

	[Token(Token = "0x60193C2")]
	[Address(RVA = "0x35BF0B4", Offset = "0x35BF0B4", VA = "0x35BF0B4")]
	public AkAmbient()
	{
	}

	[Token(Token = "0x60193C3")]
	[Address(RVA = "0x35BF174", Offset = "0x35BF174", VA = "0x35BF174")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60193C4")]
	[Address(RVA = "0x35BF850", Offset = "0x35BF850", VA = "0x35BF850", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60193C5")]
	[Address(RVA = "0x35BFF1C", Offset = "0x35BFF1C", VA = "0x35BFF1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60193C6")]
	[Address(RVA = "0x35C01E4", Offset = "0x35C01E4", VA = "0x35C01E4", Slot = "4")]
	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	[Token(Token = "0x60193C7")]
	[Address(RVA = "0x35C07E0", Offset = "0x35C07E0", VA = "0x35C07E0")]
	public void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60193C8")]
	[Address(RVA = "0x35BF58C", Offset = "0x35BF58C", VA = "0x35BF58C")]
	public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList)
	{
		return null;
	}

	[Token(Token = "0x60193C9")]
	[Address(RVA = "0x35BFB40", Offset = "0x35BFB40", VA = "0x35BFB40")]
	private AkPositionArray BuildAkPositionArray()
	{
		return null;
	}
}
