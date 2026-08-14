using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000434")]
internal class VehicleCameraBase : CameraControllerBase
{
	[Token(Token = "0x4003BC1")]
	[FieldOffset(Offset = "0x0")]
	protected static uint FEBGMPOLDPA;

	[Token(Token = "0x4003BC2")]
	[FieldOffset(Offset = "0x24")]
	public float TargetFieldOfView;

	[Token(Token = "0x4003BC3")]
	[FieldOffset(Offset = "0x28")]
	public float MinimumFOV;

	[Token(Token = "0x4003BC4")]
	[FieldOffset(Offset = "0x2C")]
	public float MaximumFOV;

	[Token(Token = "0x4003BC5")]
	[FieldOffset(Offset = "0x30")]
	public float MaximumTilt;

	[Token(Token = "0x4003BC6")]
	[FieldOffset(Offset = "0x34")]
	public float HeightDamping;

	[Token(Token = "0x4003BC7")]
	[FieldOffset(Offset = "0x38")]
	public float RotationDamping;

	[Token(Token = "0x4003BC8")]
	[FieldOffset(Offset = "0x3C")]
	public float MaxRotationDamping;

	[Token(Token = "0x4003BC9")]
	[FieldOffset(Offset = "0x40")]
	private float NENDPNCDFLJ;

	[Token(Token = "0x4003BCA")]
	[FieldOffset(Offset = "0x44")]
	protected LNCPEIAKCJO OKNJKNCIFIC;

	[Token(Token = "0x4003BCB")]
	[FieldOffset(Offset = "0x48")]
	protected float FPGGDNNFGDM;

	[Token(Token = "0x4003BCC")]
	[FieldOffset(Offset = "0x4C")]
	protected float IEMIEANHBDG;

	[Token(Token = "0x4003BCD")]
	[FieldOffset(Offset = "0x50")]
	private float _003CDDNPALIMEFK_003Ek__BackingField;

	[Token(Token = "0x4003BCE")]
	[FieldOffset(Offset = "0x54")]
	private float _003CHIDEJOFGJGG_003Ek__BackingField;

	[Token(Token = "0x4003BCF")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 NLHHMPDOJOM;

	[Token(Token = "0x4003BD0")]
	[FieldOffset(Offset = "0x64")]
	protected float EIGDMJOEEFC;

	[Token(Token = "0x4003BD1")]
	[FieldOffset(Offset = "0x68")]
	protected MADMMIICBNN GKFIJMEHHII;

	[Token(Token = "0x170001D1")]
	public float FFDIOGPKCKF
	{
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x26E462C", Offset = "0x26E462C", VA = "0x26E462C")]
		set
		{
		}
	}

	[Token(Token = "0x170001D2")]
	public float HAKCHLGNFOL
	{
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x26E4690", Offset = "0x26E4690", VA = "0x26E4690")]
		set
		{
		}
	}

	[Token(Token = "0x170001D3")]
	public float GGDCOCGIKHF
	{
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x26E46F4", Offset = "0x26E46F4", VA = "0x26E46F4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x26E46FC", Offset = "0x26E46FC", VA = "0x26E46FC")]
		set
		{
		}
	}

	[Token(Token = "0x170001D4")]
	public float EPNLPBGEFOM
	{
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x26E4704", Offset = "0x26E4704", VA = "0x26E4704")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x26E470C", Offset = "0x26E470C", VA = "0x26E470C")]
		set
		{
		}
	}

	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x26E44F8", Offset = "0x26E44F8", VA = "0x26E44F8")]
	public VehicleCameraBase()
	{
	}

	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x26E4714", Offset = "0x26E4714", VA = "0x26E4714", Slot = "5")]
	protected override void PCGJKJBMAJM()
	{
	}

	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x26E4968", Offset = "0x26E4968", VA = "0x26E4968", Slot = "6")]
	public override void OnCameraChanged()
	{
	}

	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x26E4C90", Offset = "0x26E4C90", VA = "0x26E4C90")]
	protected bool IPAPOEIGONC(Vector3 AHHKMPEKEDL, Vector3 EDDDJFDOKME, out Vector3 LJIFCKHCCEA)
	{
		return default(bool);
	}

	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x26E5084", Offset = "0x26E5084", VA = "0x26E5084")]
	public float CalculateCollisionBackOffset(Vector3 PFAPJJODMCM, Vector3 NLICKABMANM, float OOCLKIAANIO, [Optional] string HOEHMBENOFM)
	{
		return default(float);
	}

	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x26E5ED8", Offset = "0x26E5ED8", VA = "0x26E5ED8")]
	public void _003C_003EiFixBaseProxy_PCGJKJBMAJM()
	{
	}

	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x26E5EE0", Offset = "0x26E5EE0", VA = "0x26E5EE0")]
	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}
}
