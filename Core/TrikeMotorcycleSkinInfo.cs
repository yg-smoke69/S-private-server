using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D07")]
public class TrikeMotorcycleSkinInfo : MotorcyleSkinInfo
{
	[Token(Token = "0x4019E67")]
	[FieldOffset(Offset = "0xA0")]
	public Transform SideWheelModel;

	[Token(Token = "0x170019D0")]
	public override List<Transform> WheelModels
	{
		[Token(Token = "0x6018703")]
		[Address(RVA = "0x263F32C", Offset = "0x263F32C", VA = "0x263F32C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6018702")]
	[Address(RVA = "0x263F324", Offset = "0x263F324", VA = "0x263F324")]
	public TrikeMotorcycleSkinInfo()
	{
	}
}
