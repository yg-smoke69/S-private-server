using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002811")]
internal class UIHudPreparationTimerController : UIBaseController
{
	[Token(Token = "0x400F757")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPreparationTimerView m_View;

	[Token(Token = "0x400F758")]
	[FieldOffset(Offset = "0x2C")]
	private float m_StartTime;

	[Token(Token = "0x400F759")]
	[FieldOffset(Offset = "0x30")]
	private float m_TotalTime;

	[Token(Token = "0x400F75A")]
	[FieldOffset(Offset = "0x34")]
	private EPreparationTimerType m_ContextType;

	[Token(Token = "0x400F75B")]
	[FieldOffset(Offset = "0x38")]
	private AudioResource m_medKitLoopAudio;

	[Token(Token = "0x400F75C")]
	[FieldOffset(Offset = "0x3C")]
	private object m_ContextParam1;

	[Token(Token = "0x400F75D")]
	[FieldOffset(Offset = "0x40")]
	private object m_ContextParam2;

	[Token(Token = "0x400F75E")]
	[FieldOffset(Offset = "0x48")]
	private IHAAMHPPLMG m_CurrentObserverID;

	[Token(Token = "0x400F75F")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsPrepareFinished;

	[Token(Token = "0x400F760")]
	[FieldOffset(Offset = "0x64")]
	private float m_CurrentProgressSpeed;

	[Token(Token = "0x400F761")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurrentProgressRate;

	[Token(Token = "0x170011EE")]
	public EPreparationTimerType ContextType
	{
		[Token(Token = "0x600F953")]
		[Address(RVA = "0x1FBA858", Offset = "0x1FBA858", VA = "0x1FBA858")]
		get
		{
			return default(EPreparationTimerType);
		}
	}

	[Token(Token = "0x600F952")]
	[Address(RVA = "0x1FBA77C", Offset = "0x1FBA77C", VA = "0x1FBA77C")]
	public UIHudPreparationTimerController()
	{
	}

	[Token(Token = "0x600F954")]
	[Address(RVA = "0x1FBA8B0", Offset = "0x1FBA8B0", VA = "0x1FBA8B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F955")]
	[Address(RVA = "0x1FBA954", Offset = "0x1FBA954", VA = "0x1FBA954", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F956")]
	[Address(RVA = "0x1FBAEAC", Offset = "0x1FBAEAC", VA = "0x1FBAEAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600F957")]
	[Address(RVA = "0x1FBDCC0", Offset = "0x1FBDCC0", VA = "0x1FBDCC0")]
	private void UpdateProgressType()
	{
	}

	[Token(Token = "0x600F958")]
	[Address(RVA = "0x1FBF098", Offset = "0x1FBF098", VA = "0x1FBF098")]
	private void OnProgressRateChanged(object[] param)
	{
	}

	[Token(Token = "0x600F959")]
	[Address(RVA = "0x1FBF2B8", Offset = "0x1FBF2B8", VA = "0x1FBF2B8")]
	private void OnProgressSpeedChanged(object[] param)
	{
	}

	[Token(Token = "0x600F95A")]
	[Address(RVA = "0x1FBF3A0", Offset = "0x1FBF3A0", VA = "0x1FBF3A0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F95B")]
	[Address(RVA = "0x1FBF6A8", Offset = "0x1FBF6A8", VA = "0x1FBF6A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F95C")]
	[Address(RVA = "0x1FBFB1C", Offset = "0x1FBFB1C", VA = "0x1FBFB1C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600F95D")]
	[Address(RVA = "0x1FBFDFC", Offset = "0x1FBFDFC", VA = "0x1FBFDFC")]
	private void OnPreparationStart(object[] param)
	{
	}

	[Token(Token = "0x600F95E")]
	[Address(RVA = "0x1FC285C", Offset = "0x1FC285C", VA = "0x1FC285C")]
	private void OnPreparationNewCancel(object[] param)
	{
	}

	[Token(Token = "0x600F95F")]
	[Address(RVA = "0x1FC2E7C", Offset = "0x1FC2E7C", VA = "0x1FC2E7C")]
	private void OnPreparationCancel(object[] param)
	{
	}

	[Token(Token = "0x600F960")]
	[Address(RVA = "0x1FC3580", Offset = "0x1FC3580", VA = "0x1FC3580")]
	private void OnCancel(object[] param)
	{
	}

	[Token(Token = "0x600F961")]
	[Address(RVA = "0x1FC3934", Offset = "0x1FC3934", VA = "0x1FC3934")]
	private void OnPreparationEnd(object[] param)
	{
	}

	[Token(Token = "0x600F962")]
	[Address(RVA = "0x1FC3D88", Offset = "0x1FC3D88", VA = "0x1FC3D88")]
	private void OnLocalPlayerRevive(object[] param)
	{
	}

	[Token(Token = "0x600F963")]
	[Address(RVA = "0x1FC3DF0", Offset = "0x1FC3DF0", VA = "0x1FC3DF0")]
	private void OnPlayerRemoveBomb(object[] param)
	{
	}

	[Token(Token = "0x600F964")]
	[Address(RVA = "0x1FBDFC4", Offset = "0x1FBDFC4", VA = "0x1FBDFC4")]
	private void DoCancelUse(bool stopall = true)
	{
	}

	[Token(Token = "0x600F965")]
	[Address(RVA = "0x1FBD950", Offset = "0x1FBD950", VA = "0x1FBD950")]
	private void ClearData()
	{
	}

	[Token(Token = "0x600F966")]
	[Address(RVA = "0x1FBD8EC", Offset = "0x1FBD8EC", VA = "0x1FBD8EC")]
	private bool HasValidData()
	{
		return default(bool);
	}

	[Token(Token = "0x600F967")]
	[Address(RVA = "0x1FBDC50", Offset = "0x1FBDC50", VA = "0x1FBDC50")]
	private bool IsProgressType()
	{
		return default(bool);
	}

	[Token(Token = "0x600F968")]
	[Address(RVA = "0x1FC2770", Offset = "0x1FC2770", VA = "0x1FC2770")]
	private bool CannotInterrupted()
	{
		return default(bool);
	}

	[Token(Token = "0x600F969")]
	[Address(RVA = "0x1FC27DC", Offset = "0x1FC27DC", VA = "0x1FC27DC")]
	private bool CannotRetry()
	{
		return default(bool);
	}

	[Token(Token = "0x600F96A")]
	[Address(RVA = "0x1FBDF60", Offset = "0x1FBDF60", VA = "0x1FBDF60")]
	private bool CanSimulationFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x600F96B")]
	[Address(RVA = "0x1FC3EBC", Offset = "0x1FC3EBC", VA = "0x1FC3EBC")]
	private void OnDecreaseInPreparation(object[] data)
	{
	}

	[Token(Token = "0x600F96C")]
	[Address(RVA = "0x1FC406C", Offset = "0x1FC406C", VA = "0x1FC406C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600F96D")]
	[Address(RVA = "0x1FC418C", Offset = "0x1FC418C", VA = "0x1FC418C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F96E")]
	[Address(RVA = "0x1FC4194", Offset = "0x1FC4194", VA = "0x1FC4194")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F96F")]
	[Address(RVA = "0x1FC419C", Offset = "0x1FC419C", VA = "0x1FC419C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F970")]
	[Address(RVA = "0x1FC41A4", Offset = "0x1FC41A4", VA = "0x1FC41A4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
