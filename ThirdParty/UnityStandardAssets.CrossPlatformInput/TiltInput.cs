using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput;

[Token(Token = "0x2003B20")]
public class TiltInput : MonoBehaviour
{
	[Token(Token = "0x2003B21")]
	public enum AxisOptions
	{
		[Token(Token = "0x40192A5")]
		ForwardAxis,
		[Token(Token = "0x40192A6")]
		SidewaysAxis
	}

	[Serializable]
	[Token(Token = "0x2003B22")]
	public class AxisMapping
	{
		[Token(Token = "0x2003B23")]
		public enum MappingType
		{
			[Token(Token = "0x40192AA")]
			NamedAxis,
			[Token(Token = "0x40192AB")]
			MousePositionX,
			[Token(Token = "0x40192AC")]
			MousePositionY,
			[Token(Token = "0x40192AD")]
			MousePositionZ
		}

		[Token(Token = "0x40192A7")]
		[FieldOffset(Offset = "0x8")]
		public MappingType type;

		[Token(Token = "0x40192A8")]
		[FieldOffset(Offset = "0xC")]
		public string axisName;

		[Token(Token = "0x6017793")]
		[Address(RVA = "0x2A67134", Offset = "0x2A67134", VA = "0x2A67134")]
		public AxisMapping()
		{
		}
	}

	[Token(Token = "0x401929F")]
	[FieldOffset(Offset = "0xC")]
	public AxisMapping mapping;

	[Token(Token = "0x40192A0")]
	[FieldOffset(Offset = "0x10")]
	public AxisOptions tiltAroundAxis;

	[Token(Token = "0x40192A1")]
	[FieldOffset(Offset = "0x14")]
	public float fullTiltAngle;

	[Token(Token = "0x40192A2")]
	[FieldOffset(Offset = "0x18")]
	public float centreAngleOffset;

	[Token(Token = "0x40192A3")]
	[FieldOffset(Offset = "0x1C")]
	private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

	[Token(Token = "0x601778F")]
	[Address(RVA = "0x2A66CE8", Offset = "0x2A66CE8", VA = "0x2A66CE8")]
	public TiltInput()
	{
	}

	[Token(Token = "0x6017790")]
	[Address(RVA = "0x2A66CFC", Offset = "0x2A66CFC", VA = "0x2A66CFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6017791")]
	[Address(RVA = "0x2A66DE4", Offset = "0x2A66DE4", VA = "0x2A66DE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6017792")]
	[Address(RVA = "0x2A6710C", Offset = "0x2A6710C", VA = "0x2A6710C")]
	private void OnDisable()
	{
	}
}
