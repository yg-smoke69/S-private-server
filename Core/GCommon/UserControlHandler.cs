using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EE2")]
internal class UserControlHandler
{
	[Token(Token = "0x401A8A2")]
	[FieldOffset(Offset = "0x8")]
	private UserControlMapping m_UserControlMapping;

	[Token(Token = "0x401A8A3")]
	[FieldOffset(Offset = "0xC")]
	private float[] m_RawDataCache;

	[Token(Token = "0x401A8A4")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsButtonEnable;

	[Token(Token = "0x401A8A5")]
	[FieldOffset(Offset = "0x11")]
	private bool m_IsInputEnable;

	[Token(Token = "0x401A8A6")]
	[FieldOffset(Offset = "0x14")]
	private UserControlAxisData[] m_AxisData;

	[Token(Token = "0x401A8A7")]
	[FieldOffset(Offset = "0x18")]
	private float[] m_LastRawDataCache;

	[Token(Token = "0x401A8A8")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_IsUserControlChanged;

	[Token(Token = "0x401A8A9")]
	[FieldOffset(Offset = "0x20")]
	private UserControlTouchData m_CurrentTouchData;

	[Token(Token = "0x401A8AA")]
	[FieldOffset(Offset = "0x24")]
	private bool m_EnableRecordTouchInfo;

	[Token(Token = "0x401A8AB")]
	[FieldOffset(Offset = "0x25")]
	private bool m_EnableFixStationaryAxisMoving;

	[Token(Token = "0x401A8AC")]
	[FieldOffset(Offset = "0x28")]
	private float m_FixStationaryAxisMovingThreshold;

	[Token(Token = "0x401A8AD")]
	[FieldOffset(Offset = "0x2C")]
	private int m_FingerInDashArea;

	[Token(Token = "0x401A8AE")]
	[FieldOffset(Offset = "0x30")]
	private bool m_LockFingerInDashArea;

	[Token(Token = "0x401A8AF")]
	public const int SPEEDUP_LOCK_THRESHOLD = 3;

	[Token(Token = "0x401A8B0")]
	[FieldOffset(Offset = "0x0")]
	public static float m_resolutionResetScale;

	[Token(Token = "0x401A8B1")]
	[FieldOffset(Offset = "0x31")]
	private bool m_HasAxisHandled;

	[Token(Token = "0x17001BFC")]
	public float[] RawDataCache
	{
		[Token(Token = "0x60199BD")]
		[Address(RVA = "0x2BD1E70", Offset = "0x2BD1E70", VA = "0x2BD1E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60199BE")]
		[Address(RVA = "0x2BD1E78", Offset = "0x2BD1E78", VA = "0x2BD1E78")]
		private set
		{
		}
	}

	[Token(Token = "0x60199BA")]
	[Address(RVA = "0x2BD0020", Offset = "0x2BD0020", VA = "0x2BD0020")]
	public UserControlHandler()
	{
	}

	[Token(Token = "0x60199BB")]
	[Address(RVA = "0x2BD1D6C", Offset = "0x2BD1D6C", VA = "0x2BD1D6C")]
	private void HandleAction(float gameTime = 0f, float deltaTime = 0f)
	{
	}

	[Token(Token = "0x60199BC")]
	[Address(RVA = "0x2BD1D70", Offset = "0x2BD1D70", VA = "0x2BD1D70")]
	private bool isCombinationKey(EventModifiers prekey, KeyCode postkey, EventType postkeyevent)
	{
		return default(bool);
	}

	[Token(Token = "0x60199BF")]
	[Address(RVA = "0x2BD1E7C", Offset = "0x2BD1E7C", VA = "0x2BD1E7C")]
	public void SetRecordTouchInfoEnable(bool enable)
	{
	}

	[Token(Token = "0x60199C0")]
	[Address(RVA = "0x2BD2010", Offset = "0x2BD2010", VA = "0x2BD2010")]
	public void SetFixStationaryAxisMoving(bool enable, float threshold)
	{
	}

	[Token(Token = "0x60199C1")]
	[Address(RVA = "0x2BD201C", Offset = "0x2BD201C", VA = "0x2BD201C")]
	public void SetButtonEnable(bool enable)
	{
	}

	[Token(Token = "0x60199C2")]
	[Address(RVA = "0x2BD2024", Offset = "0x2BD2024", VA = "0x2BD2024")]
	public bool IsLockKeyAction()
	{
		return default(bool);
	}

	[Token(Token = "0x60199C3")]
	[Address(RVA = "0x2BD202C", Offset = "0x2BD202C", VA = "0x2BD202C")]
	public void SetInputEnable(bool enable)
	{
	}

	[Token(Token = "0x60199C4")]
	[Address(RVA = "0x2BD2034", Offset = "0x2BD2034", VA = "0x2BD2034")]
	public bool GetInputState()
	{
		return default(bool);
	}

	[Token(Token = "0x60199C5")]
	[Address(RVA = "0x2BD203C", Offset = "0x2BD203C", VA = "0x2BD203C")]
	public void ResetButton(int key)
	{
	}

	[Token(Token = "0x60199C6")]
	[Address(RVA = "0x2BD20C8", Offset = "0x2BD20C8", VA = "0x2BD20C8")]
	public void AddAxisData(int hKey, int vKey, float acturallyMovedDist, UserControlAxisData.EAxisDataType t)
	{
	}

	[Token(Token = "0x60199C7")]
	[Address(RVA = "0x2BD22E8", Offset = "0x2BD22E8", VA = "0x2BD22E8")]
	public void UpdateAxis(float gameTime = 0f, float deltaTime = 0f)
	{
	}

	[Token(Token = "0x60199C8")]
	[Address(RVA = "0x2BD28F4", Offset = "0x2BD28F4", VA = "0x2BD28F4")]
	public void UpdateRawDataCache(int axisIndex)
	{
	}

	[Token(Token = "0x60199C9")]
	[Address(RVA = "0x2BD29F0", Offset = "0x2BD29F0", VA = "0x2BD29F0")]
	public void Update(float gameTime = 0f, float deltaTime = 0f)
	{
	}

	[Token(Token = "0x60199CA")]
	[Address(RVA = "0x2BD3DA0", Offset = "0x2BD3DA0", VA = "0x2BD3DA0")]
	public void UpdateRightAxis()
	{
	}

	[Token(Token = "0x60199CB")]
	[Address(RVA = "0x2BD3828", Offset = "0x2BD3828", VA = "0x2BD3828")]
	private void RecordTouchInfo()
	{
	}

	[Token(Token = "0x60199CC")]
	[Address(RVA = "0x2BD41F4", Offset = "0x2BD41F4", VA = "0x2BD41F4")]
	public bool IsAuxAimBtnDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60199CD")]
	[Address(RVA = "0x2BD41FC", Offset = "0x2BD41FC", VA = "0x2BD41FC")]
	public bool IsButtonDown(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x60199CE")]
	[Address(RVA = "0x2BD4268", Offset = "0x2BD4268", VA = "0x2BD4268")]
	public bool IsButtonDown(string kcMapName)
	{
		return default(bool);
	}

	[Token(Token = "0x60199CF")]
	[Address(RVA = "0x2BD4270", Offset = "0x2BD4270", VA = "0x2BD4270")]
	public bool IsButtonUp(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x60199D0")]
	[Address(RVA = "0x2BD42DC", Offset = "0x2BD42DC", VA = "0x2BD42DC")]
	public bool IsButtonUp(string kcMapName)
	{
		return default(bool);
	}

	[Token(Token = "0x60199D1")]
	[Address(RVA = "0x2BD42E4", Offset = "0x2BD42E4", VA = "0x2BD42E4")]
	public bool IsButtonReleased(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x60199D2")]
	[Address(RVA = "0x2BD4488", Offset = "0x2BD4488", VA = "0x2BD4488")]
	public bool IsButtonReleased(string kcMapName)
	{
		return default(bool);
	}

	[Token(Token = "0x60199D3")]
	[Address(RVA = "0x2BD4490", Offset = "0x2BD4490", VA = "0x2BD4490")]
	public bool IsButtonPressed(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x60199D4")]
	[Address(RVA = "0x2BD4634", Offset = "0x2BD4634", VA = "0x2BD4634")]
	public bool IsButtonPressed(string kcMapName)
	{
		return default(bool);
	}

	[Token(Token = "0x60199D5")]
	[Address(RVA = "0x2BD463C", Offset = "0x2BD463C", VA = "0x2BD463C")]
	public bool HaveRecoredTouchPosition()
	{
		return default(bool);
	}

	[Token(Token = "0x60199D6")]
	[Address(RVA = "0x2BD4738", Offset = "0x2BD4738", VA = "0x2BD4738")]
	public Vector3 GetRecordedTouchPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199D7")]
	[Address(RVA = "0x2BD48A8", Offset = "0x2BD48A8", VA = "0x2BD48A8")]
	public bool IsUserControlChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x60199D8")]
	[Address(RVA = "0x2BD48B0", Offset = "0x2BD48B0", VA = "0x2BD48B0")]
	public Vector3 GetDirectionLeft()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199D9")]
	[Address(RVA = "0x2BD4914", Offset = "0x2BD4914", VA = "0x2BD4914")]
	public Vector3 GetAxisDeltaLeft()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199DA")]
	[Address(RVA = "0x2BD4978", Offset = "0x2BD4978", VA = "0x2BD4978")]
	public Vector3 GetDirectionRight()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199DB")]
	[Address(RVA = "0x2BD49DC", Offset = "0x2BD49DC", VA = "0x2BD49DC")]
	public Vector3 GetAxisDeltaRight()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199DC")]
	[Address(RVA = "0x2BD4A40", Offset = "0x2BD4A40", VA = "0x2BD4A40")]
	public Vector3 GetDirectionWeaponSlider()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199DD")]
	[Address(RVA = "0x2BD4B70", Offset = "0x2BD4B70", VA = "0x2BD4B70")]
	public Vector3 GetAxisDeltaWeaponSlider()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199DE")]
	[Address(RVA = "0x2BD4BD4", Offset = "0x2BD4BD4", VA = "0x2BD4BD4")]
	public Vector3 GetDirectionRouletteSilder()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199DF")]
	[Address(RVA = "0x2BD4D04", Offset = "0x2BD4D04", VA = "0x2BD4D04")]
	public Vector3 GetAxisDeltaRouletteSlider()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199E0")]
	[Address(RVA = "0x2BD4D68", Offset = "0x2BD4D68", VA = "0x2BD4D68")]
	public UserControlAxisData GetAxisData(int axisIndex)
	{
		return null;
	}

	[Token(Token = "0x60199E1")]
	[Address(RVA = "0x2BD4DB0", Offset = "0x2BD4DB0", VA = "0x2BD4DB0")]
	public Vector3 GetShiftedDirectionWithCamera(Camera camera, int axisIndex = 0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199E2")]
	[Address(RVA = "0x2BD3C24", Offset = "0x2BD3C24", VA = "0x2BD3C24")]
	private bool IsAxisChanged(Vector3 curVec, Vector3 lastVec)
	{
		return default(bool);
	}

	[Token(Token = "0x60199E3")]
	[Address(RVA = "0x2BD2468", Offset = "0x2BD2468", VA = "0x2BD2468")]
	private void UpdateAxis(int axisIndex)
	{
	}

	[Token(Token = "0x60199E4")]
	[Address(RVA = "0x2BD5080", Offset = "0x2BD5080", VA = "0x2BD5080")]
	private bool OnTouchBegin(UserControlAxisData axisData)
	{
		return default(bool);
	}

	[Token(Token = "0x60199E5")]
	[Address(RVA = "0x2BD515C", Offset = "0x2BD515C", VA = "0x2BD515C")]
	private bool OnTouchMove(UserControlAxisData axisData)
	{
		return default(bool);
	}

	[Token(Token = "0x60199E6")]
	[Address(RVA = "0x2BD530C", Offset = "0x2BD530C", VA = "0x2BD530C")]
	private bool OnTouchStationary(UserControlAxisData axisData)
	{
		return default(bool);
	}

	[Token(Token = "0x60199E7")]
	[Address(RVA = "0x2BD5274", Offset = "0x2BD5274", VA = "0x2BD5274")]
	private bool OnTouchEnd(UserControlAxisData axisData)
	{
		return default(bool);
	}

	[Token(Token = "0x60199E8")]
	[Address(RVA = "0x2BD5480", Offset = "0x2BD5480", VA = "0x2BD5480")]
	private void UpdateSpeedUpStates(UserControlAxisData axisData, TouchPhase tp)
	{
	}

	[Token(Token = "0x60199E9")]
	[Address(RVA = "0x2BD5430", Offset = "0x2BD5430", VA = "0x2BD5430")]
	public void CleanupTouchData(UserControlAxisData axisData)
	{
	}

	[Token(Token = "0x60199EA")]
	[Address(RVA = "0x2BD54B4", Offset = "0x2BD54B4", VA = "0x2BD54B4")]
	public void SetFingerDashArea(int area)
	{
	}

	[Token(Token = "0x60199EB")]
	[Address(RVA = "0x2BD54BC", Offset = "0x2BD54BC", VA = "0x2BD54BC")]
	public bool IsFingerInDashArea()
	{
		return default(bool);
	}

	[Token(Token = "0x60199EC")]
	[Address(RVA = "0x2BD54E4", Offset = "0x2BD54E4", VA = "0x2BD54E4")]
	public void SetLockFingerInDashArea(bool isLock)
	{
	}

	[Token(Token = "0x60199ED")]
	[Address(RVA = "0x2BD54EC", Offset = "0x2BD54EC", VA = "0x2BD54EC")]
	public bool GetLockFingerInDashArea()
	{
		return default(bool);
	}
}
