using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200041E")]
internal class CameraControllerManager : MonoBehaviour
{
	[Token(Token = "0x200041F")]
	public enum KCGNAFGBOLL
	{
		[Token(Token = "0x4003B07")]
		Follow,
		[Token(Token = "0x4003B08")]
		VehicleDriver,
		[Token(Token = "0x4003B09")]
		VehiclePassenger,
		[Token(Token = "0x4003B0A")]
		Skydiving,
		[Token(Token = "0x4003B0B")]
		Death,
		[Token(Token = "0x4003B0C")]
		Free,
		[Token(Token = "0x4003B0D")]
		PendingRevive,
		[Token(Token = "0x4003B0E")]
		Opening,
		[Token(Token = "0x4003B0F")]
		NewDeath,
		[Token(Token = "0x4003B10")]
		FerrisWheel,
		[Token(Token = "0x4003B11")]
		SceneEdit,
		[Token(Token = "0x4003B12")]
		FreeFollow,
		[Token(Token = "0x4003B13")]
		LudoGame,
		[Token(Token = "0x4003B14")]
		NB
	}

	[Token(Token = "0x2000420")]
	public delegate void ACEFOIJADIA(int FMDLIFDMEBC, int AODPEMDOCLE);

	[Token(Token = "0x4003AFF")]
	[FieldOffset(Offset = "0xC")]
	private Camera PEAACFHPIFG;

	[Token(Token = "0x4003B00")]
	[FieldOffset(Offset = "0x10")]
	private BlackWhiteEffect LLIAOIMNOIN;

	[Token(Token = "0x4003B01")]
	[FieldOffset(Offset = "0x14")]
	private RoundnessFadeEffect IPIKPNBBPEM;

	[Token(Token = "0x4003B02")]
	[FieldOffset(Offset = "0x18")]
	private CameraControllerBase[] MMKANCFEFDF;

	[Token(Token = "0x4003B03")]
	[FieldOffset(Offset = "0x1C")]
	private KCGNAFGBOLL HOBHLHILFEP;

	[Token(Token = "0x4003B04")]
	[FieldOffset(Offset = "0x20")]
	private ACEFOIJADIA PGLOJMNLKAI;

	[Token(Token = "0x4003B05")]
	[FieldOffset(Offset = "0x24")]
	private bool BOPFINBKNIA;

	[Token(Token = "0x170001C6")]
	public Camera ANKLHKKAELI
	{
		[Token(Token = "0x600144D")]
		[Address(RVA = "0x1E936E0", Offset = "0x1E936E0", VA = "0x1E936E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600144C")]
	[Address(RVA = "0x1E936D0", Offset = "0x1E936D0", VA = "0x1E936D0")]
	public CameraControllerManager()
	{
	}

	[Token(Token = "0x600144E")]
	[Address(RVA = "0x1E93738", Offset = "0x1E93738", VA = "0x1E93738")]
	private void Awake()
	{
	}

	[Token(Token = "0x600144F")]
	[Address(RVA = "0x1E93D6C", Offset = "0x1E93D6C", VA = "0x1E93D6C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001450")]
	[Address(RVA = "0x1E93E94", Offset = "0x1E93E94", VA = "0x1E93E94")]
	private void EOOFODDDLAF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6001451")]
	[Address(RVA = "0x1E94040", Offset = "0x1E94040", VA = "0x1E94040")]
	public void Shutdown()
	{
	}

	[Token(Token = "0x6001452")]
	[Address(RVA = "0x1E94108", Offset = "0x1E94108", VA = "0x1E94108")]
	public void RegistCameraChangedCallBack(ACEFOIJADIA GHGMACFOJOH)
	{
	}

	[Token(Token = "0x6001453")]
	[Address(RVA = "0x1E93B04", Offset = "0x1E93B04", VA = "0x1E93B04")]
	public void ChangeCamera(KCGNAFGBOLL GKPKNOLKNBE, bool HOLBGKLLBFI = false, [Optional] MPICKNDAPEB JMJJFDLFCCI, bool MKLKBFHMNBD = false)
	{
	}

	[Token(Token = "0x6001454")]
	[Address(RVA = "0x1E94610", Offset = "0x1E94610", VA = "0x1E94610")]
	public void ClearCurrentTargetEntity()
	{
	}

	[Token(Token = "0x6001455")]
	[Address(RVA = "0x1E946E4", Offset = "0x1E946E4", VA = "0x1E946E4")]
	public void ClearAllTargetEntity()
	{
	}

	[Token(Token = "0x6001456")]
	public T GetCameraController<T>(KCGNAFGBOLL NPANDAPGAIN) where T : CameraControllerBase
	{
		return null;
	}

	[Token(Token = "0x6001457")]
	[Address(RVA = "0x1E94870", Offset = "0x1E94870", VA = "0x1E94870")]
	public void ShowRebornModeBlackWhiteEffect()
	{
	}

	[Token(Token = "0x6001458")]
	[Address(RVA = "0x1E94244", Offset = "0x1E94244", VA = "0x1E94244")]
	public void StopRebornModeBlackWhiteEffect()
	{
	}

	[Token(Token = "0x6001459")]
	[Address(RVA = "0x1E94BCC", Offset = "0x1E94BCC", VA = "0x1E94BCC")]
	public void ShowRoundnessFadeEffect(Color MGAOFBNFAKF, float BAJIOEGPDAN, float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x600145A")]
	[Address(RVA = "0x1E94EE8", Offset = "0x1E94EE8", VA = "0x1E94EE8")]
	public void StopRoundnessFadeEffect()
	{
	}

	[Token(Token = "0x600145B")]
	private void JEDONCFDBPE<T>(KCGNAFGBOLL NPANDAPGAIN) where T : CameraControllerBase
	{
	}

	[Token(Token = "0x600145C")]
	[Address(RVA = "0x1E94FE8", Offset = "0x1E94FE8", VA = "0x1E94FE8")]
	public KCGNAFGBOLL GetCurrentECameraControllerType()
	{
		return default(KCGNAFGBOLL);
	}

	[Token(Token = "0x600145D")]
	[Address(RVA = "0x1E93498", Offset = "0x1E93498", VA = "0x1E93498")]
	public void OnCameraUpdated()
	{
	}

	[Token(Token = "0x600145E")]
	[Address(RVA = "0x1E95040", Offset = "0x1E95040", VA = "0x1E95040")]
	public void CopyPostEffectToCamera(Camera IFPMCEFKDEC)
	{
	}
}
