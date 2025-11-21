import streamlit as st
import base64

st.set_page_config(
    page_title="Hello",
    page_icon="🏠",
)

def add_bg_from_local(image_file):
    with open(image_file, "rb") as image_file:
        encoded_string = base64.b64encode(image_file.read())
    st.markdown(
    f"""
    <style>
    .stApp {{
        background-image: url(data:image/{"png"};base64,{encoded_string.decode()});
        background-size: cover
    }}
    </style>
    """,
    unsafe_allow_html=True
    )
add_bg_from_local('E:/TAI_LIEU_DAI_HOC/SEMESTER_6/XuLyAnh/FinalProject/Background/Homepage.png')  

st.markdown("""
<style>
    [data-testid=stSidebar] 
    {
        background-color: #7F736A;
        width: 100%; /* Đặt chiều rộng của sidebar là 100% */
        order: -1; /* Đặt sidebar ở trên cùng */
    }
    .stSidebar .success 
    {
        color: black; /* Đặt màu chữ của sidebar là đen */
    }
</style>
""", unsafe_allow_html=True)
  
st.markdown(
    """
    <style>
    .red-text {
        color: white;
    }
    </style>
    """,
    unsafe_allow_html=True
)

