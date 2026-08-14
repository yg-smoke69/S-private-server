using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200041D")]
internal abstract class CameraControllerBase : MonoBehaviour
{
	[Token(Token = "0x4003AF9")]
	[FieldOffset(Offset = "0xC")]
	public CameraControllerManager m_Manager;

	[Token(Token = "0x4003AFA")]
	[FieldOffset(Offset = "0x10")]
	protected Camera FCKFGJMEECI;

	[Token(Token = "0x4003AFB")]
	[FieldOffset(Offset = "0x14")]
	public bool ClearTargetOnDisableOnce;

	[Token(Token = "0x4003AFC")]
	[FieldOffset(Offset = "0x18")]
	protected MPICKNDAPEB NHPLIOAJEEL;

	[Token(Token = "0x4003AFD")]
	[FieldOffset(Offset = "0x1C")]
	protected Transform PIPJMONKGBI;

	[Token(Token = "0x4003AFE")]
	[FieldOffset(Offset = "0x20")]
	protected AODOBDHLDLM PMLKNGOKMCA;

	[Token(Token = "0x170001C3")]
	public Camera ICGIFNHNIFB
	{
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x1E92C2C", Offset = "0x1E92C2C", VA = "0x1E92C2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x1E92C84", Offset = "0x1E92C84", VA = "0x1E92C84")]
		set
		{
		}
	}

	[Token(Token = "0x170001C4")]
	public MPICKNDAPEB MCAPEOEFBPK
	{
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x1E92D68", Offset = "0x1E92D68", VA = "0x1E92D68")]
		protected get
		{
			return null;
		}
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x1E92CE4", Offset = "0x1E92CE4", VA = "0x1E92CE4")]
		set
		{
		}
	}

	[Token(Token = "0x170001C5")]
	public Transform NFDCGOEKJCJ
	{
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x1E92E38", Offset = "0x1E92E38", VA = "0x1E92E38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600143B")]
	[Address(RVA = "0x1E92BB0", Offset = "0x1E92BB0", VA = "0x1E92BB0")]
	protected CameraControllerBase()
	{
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0x1E92DC0", Offset = "0x1E92DC0", VA = "0x1E92DC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0x1E92F94", Offset = "0x1E92F94", VA = "0x1E92F94")]
	public void StartCameraShake(float LEBOAIEJCPJ, float GEFGNGCDHJF)
	{
	}

	[Token(Token = "0x6001443")]
	[Address(RVA = "0x1E93048", Offset = "0x1E93048", VA = "0x1E93048")]
	public void EndCameraShake()
	{
	}

	[Token(Token = "0x6001444")]
	[Address(RVA = "0x1E930C0", Offset = "0x1E930C0", VA = "0x1E930C0")]
	public void StartEnforcedCameraShake(float LEBOAIEJCPJ, Vector2 IGDGKHHHHGJ)
	{
	}

	[Token(Token = "0x6001445")]
	[Address(RVA = "0x1E9317C", Offset = "0x1E9317C", VA = "0x1E9317C")]
	public void EndEnforcedCameraShake()
	{
	}

	[Token(Token = "0x6001446")]
	[Address(RVA = "0x1E931F4", Offset = "0x1E931F4", VA = "0x1E931F4")]
	public void StartRotationCameraShake(float LEBOAIEJCPJ, float GEFGNGCDHJF)
	{
	}

	[Token(Token = "0x6001447")]
	[Address(RVA = "0x1E932A8", Offset = "0x1E932A8", VA = "0x1E932A8")]
	public bool IsCameraRShaking()
	{
		return default(bool);
	}

	[Token(Token = "0x6001448")]
	[Address(RVA = "0x1E93320", Offset = "0x1E93320", VA = "0x1E93320")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001449")]
	[Address(RVA = "0x1E935D4", Offset = "0x1E935D4", VA = "0x1E935D4", Slot = "4")]
	protected virtual void IMEHMEOBENM()
	{
	}

	[Token(Token = "0x600144A")]
	[Address(RVA = "0x1E93628", Offset = "0x1E93628", VA = "0x1E93628", Slot = "5")]
	protected virtual void PCGJKJBMAJM()
	{
	}

	[Token(Token = "0x600144B")]
	[Address(RVA = "0x1E9367C", Offset = "0x1E9367C", VA = "0x1E9367C", Slot = "6")]
	public virtual void OnCameraChanged()
	{
	}
}
