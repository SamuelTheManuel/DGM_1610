using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

     public TextMeshProUGUI ui;
    public static PlayerController instance;
    public float moveSpeed = 10f;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;

    public float mouseSensitivity = 1.0f;

    public Camera viewCam;
    [Header ("Effects")]
    public GameObject bulletImpact;
    //public GameObject MuzzleFlash;
    public int currentAmmo = 10;
    private void Awake() {
        instance = this;


    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ui.text = "Ammo: " + currentAmmo;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // getting input from keyboard
        Vector3 moveH  = transform.right * moveInput.x;//used for blending movement
        Vector3 moveV = transform.forward * moveInput.z;
        rb.velocity = (moveH + moveV) * moveSpeed;

        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + mouseInput.x, transform.rotation.eulerAngles.z);
        if (Input.GetMouseButtonDown(0)) {
            if (currentAmmo > 0) {
                Ray ray = viewCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                RaycastHit hit;
                
                
                if(Physics.Raycast(ray, out hit)) {
                    //hey you are hitting something
                    Debug.Log("i'm looking at " + hit.transform.name);
                    Instantiate(bulletImpact, hit.point, transform.rotation);
                }
                else {
                    Debug.Log("Raycast isnt hitting anything");
                }
                currentAmmo --;
                //UpdateAmmo(currentAmmo);
                ui.text = "Ammo: " + currentAmmo;



            }
        }
    }
    // void UpdateAmmo(int currammo) {
    //     ui.text = "Ammo: " + currammo;
    // }
}
