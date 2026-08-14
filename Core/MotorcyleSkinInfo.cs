using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D06")]
public class MotorcyleSkinInfo : VehicleSkinInfoBase
{
	[Token(Token = "0x4019E60")]
	[FieldOffset(Offset = "0x84")]
	public Transform MotorcyleBodyModel;

	[Token(Token = "0x4019E61")]
	[FieldOffset(Offset = "0x88")]
	public Transform VehicleBrakeLight;

	[Token(Token = "0x4019E62")]
	[FieldOffset(Offset = "0x8C")]
	public Transform FrontWheelModel;

	[Token(Token = "0x4019E63")]
	[FieldOffset(Offset = "0x90")]
	public Transform RearWheelModel;

	[Token(Token = "0x4019E64")]
	[FieldOffset(Offset = "0x94")]
	public Transform FenderModel;

	[Token(Token = "0x4019E65")]
	[FieldOffset(Offset = "0x98")]
	public Transform SteerHandleModel;

	[Token(Token = "0x4019E66")]
	[FieldOffset(Offset = "0x9C")]
	protected List<Transform> m_WheelModels;

	[Token(Token = "0x170019CE")]
	public override Transform BodyModel
	{
		[Token(Token = "0x60186FC")]
		[Address(RVA = "0x1C71380", Offset = "0x1C71380", VA = "0x1C71380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019CF")]
	public override List<Transform> WheelModels
	{
		[Token(Token = "0x60186FD")]
		[Address(RVA = "0x1C71388", Offset = "0x1C71388", VA = "0x1C71388", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60186FB")]
	[Address(RVA = "0x1C71378", Offset = "0x1C71378", VA = "0x1C71378")]
	public MotorcyleSkinInfo()
	{
	}

	[Token(Token = "0x60186FE")]
	[Address(RVA = "0x1C71498", Offset = "0x1C71498", VA = "0x1C71498", Slot = "6")]
	public override void SetSkinState(bool is_show)
	{
	}

	[Token(Token = "0x60186FF")]
	[Address(RVA = "0x1C71820", Offset = "0x1C71820", VA = "0x1C71820", Slot = "7")]
	public override void ClearSkinAttached()
	{
	}

	[Token(Token = "0x6018700")]
	[Address(RVA = "0x1C71B64", Offset = "0x1C71B64", VA = "0x1C71B64", Slot = "8")]
	public override void EnableBrakeLightsEffect(bool enable)
	{
	}

	[Token(Token = "0x6018701")]
	[Address(RVA = "0x1C71C40", Offset = "0x1C71C40", VA = "0x1C71C40", Slot = "9")]
	public override void EnableTailAimi(int state)
	{
	}
}
