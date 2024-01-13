PGDMP                        |            spotify    16.1    16.1 :               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    24838    spotify    DATABASE     �   CREATE DATABASE spotify WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1254';
    DROP DATABASE spotify;
                postgres    false            �            1259    24839 
   tblcomment    TABLE     �   CREATE TABLE public.tblcomment (
    songid integer,
    commenttext character varying(100),
    commentdate date DEFAULT CURRENT_TIMESTAMP,
    userid integer,
    commentid bigint NOT NULL
);
    DROP TABLE public.tblcomment;
       public         heap    postgres    false            �            1259    24953    tblcomment_commentid_seq    SEQUENCE     �   CREATE SEQUENCE public.tblcomment_commentid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.tblcomment_commentid_seq;
       public          postgres    false    215                       0    0    tblcomment_commentid_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.tblcomment_commentid_seq OWNED BY public.tblcomment.commentid;
          public          postgres    false    227            �            1259    24843 
   tbldevices    TABLE     �   CREATE TABLE public.tbldevices (
    devicename character varying(100),
    linkdate date DEFAULT CURRENT_TIMESTAMP,
    lastplayeddate date,
    userid integer,
    deviceid bigint NOT NULL
);
    DROP TABLE public.tbldevices;
       public         heap    postgres    false            �            1259    24960    tbldevices_deviceid_seq    SEQUENCE     �   CREATE SEQUENCE public.tbldevices_deviceid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.tbldevices_deviceid_seq;
       public          postgres    false    216                       0    0    tbldevices_deviceid_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.tbldevices_deviceid_seq OWNED BY public.tbldevices.deviceid;
          public          postgres    false    228            �            1259    24847    tblfavouritesong    TABLE     ~   CREATE TABLE public.tblfavouritesong (
    songid integer,
    likedate date DEFAULT CURRENT_TIMESTAMP,
    userid integer
);
 $   DROP TABLE public.tblfavouritesong;
       public         heap    postgres    false            �            1259    24851    tblfolloweduser    TABLE     �   CREATE TABLE public.tblfolloweduser (
    followinguser integer,
    followeduser integer NOT NULL,
    followstartdate date DEFAULT CURRENT_TIMESTAMP
);
 #   DROP TABLE public.tblfolloweduser;
       public         heap    postgres    false            �            1259    24855    tblplaylist    TABLE     �   CREATE TABLE public.tblplaylist (
    playlistname character varying(50),
    creationdate date DEFAULT CURRENT_TIMESTAMP,
    userid integer,
    playlistid bigint NOT NULL
);
    DROP TABLE public.tblplaylist;
       public         heap    postgres    false            �            1259    24946    tblplaylist_playlistid_seq    SEQUENCE     �   CREATE SEQUENCE public.tblplaylist_playlistid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.tblplaylist_playlistid_seq;
       public          postgres    false    219                       0    0    tblplaylist_playlistid_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.tblplaylist_playlistid_seq OWNED BY public.tblplaylist.playlistid;
          public          postgres    false    226            �            1259    24859    tblpremiummembership    TABLE     g   CREATE TABLE public.tblpremiummembership (
    startdate date,
    enddate date,
    userid integer
);
 (   DROP TABLE public.tblpremiummembership;
       public         heap    postgres    false            �            1259    24862    tblsearchhistory    TABLE     �   CREATE TABLE public.tblsearchhistory (
    searchname character varying(100),
    searchdate date DEFAULT CURRENT_TIMESTAMP,
    userid integer
);
 $   DROP TABLE public.tblsearchhistory;
       public         heap    postgres    false            �            1259    24866    tblsessionhistory    TABLE     �   CREATE TABLE public.tblsessionhistory (
    sessiondate date DEFAULT CURRENT_TIMESTAMP,
    operationstatus character varying(100),
    userid integer
);
 %   DROP TABLE public.tblsessionhistory;
       public         heap    postgres    false            �            1259    24870    tblsong    TABLE     �   CREATE TABLE public.tblsong (
    songname character varying(50),
    singer character varying(50),
    songtype character varying(100),
    restcount integer,
    songid bigint NOT NULL,
    releaseyear date
);
    DROP TABLE public.tblsong;
       public         heap    postgres    false            �            1259    24967    tblsong_songid_seq    SEQUENCE     {   CREATE SEQUENCE public.tblsong_songid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.tblsong_songid_seq;
       public          postgres    false    223            	           0    0    tblsong_songid_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.tblsong_songid_seq OWNED BY public.tblsong.songid;
          public          postgres    false    229            �            1259    24873    tbluser    TABLE     �   CREATE TABLE public.tbluser (
    username character varying(50),
    password character varying(50),
    email character varying(100),
    creationdate date DEFAULT CURRENT_TIMESTAMP,
    userid bigint NOT NULL
);
    DROP TABLE public.tbluser;
       public         heap    postgres    false            �            1259    24877    tbluser_userid_seq    SEQUENCE     {   CREATE SEQUENCE public.tbluser_userid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.tbluser_userid_seq;
       public          postgres    false    224            
           0    0    tbluser_userid_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.tbluser_userid_seq OWNED BY public.tbluser.userid;
          public          postgres    false    225            C           2604    24954    tblcomment commentid    DEFAULT     |   ALTER TABLE ONLY public.tblcomment ALTER COLUMN commentid SET DEFAULT nextval('public.tblcomment_commentid_seq'::regclass);
 C   ALTER TABLE public.tblcomment ALTER COLUMN commentid DROP DEFAULT;
       public          postgres    false    227    215            E           2604    24961    tbldevices deviceid    DEFAULT     z   ALTER TABLE ONLY public.tbldevices ALTER COLUMN deviceid SET DEFAULT nextval('public.tbldevices_deviceid_seq'::regclass);
 B   ALTER TABLE public.tbldevices ALTER COLUMN deviceid DROP DEFAULT;
       public          postgres    false    228    216            I           2604    24947    tblplaylist playlistid    DEFAULT     �   ALTER TABLE ONLY public.tblplaylist ALTER COLUMN playlistid SET DEFAULT nextval('public.tblplaylist_playlistid_seq'::regclass);
 E   ALTER TABLE public.tblplaylist ALTER COLUMN playlistid DROP DEFAULT;
       public          postgres    false    226    219            L           2604    24968    tblsong songid    DEFAULT     p   ALTER TABLE ONLY public.tblsong ALTER COLUMN songid SET DEFAULT nextval('public.tblsong_songid_seq'::regclass);
 =   ALTER TABLE public.tblsong ALTER COLUMN songid DROP DEFAULT;
       public          postgres    false    229    223            N           2604    24878    tbluser userid    DEFAULT     p   ALTER TABLE ONLY public.tbluser ALTER COLUMN userid SET DEFAULT nextval('public.tbluser_userid_seq'::regclass);
 =   ALTER TABLE public.tbluser ALTER COLUMN userid DROP DEFAULT;
       public          postgres    false    225    224            �          0    24839 
   tblcomment 
   TABLE DATA           Y   COPY public.tblcomment (songid, commenttext, commentdate, userid, commentid) FROM stdin;
    public          postgres    false    215   �D       �          0    24843 
   tbldevices 
   TABLE DATA           \   COPY public.tbldevices (devicename, linkdate, lastplayeddate, userid, deviceid) FROM stdin;
    public          postgres    false    216   �E       �          0    24847    tblfavouritesong 
   TABLE DATA           D   COPY public.tblfavouritesong (songid, likedate, userid) FROM stdin;
    public          postgres    false    217   pF       �          0    24851    tblfolloweduser 
   TABLE DATA           W   COPY public.tblfolloweduser (followinguser, followeduser, followstartdate) FROM stdin;
    public          postgres    false    218   �F       �          0    24855    tblplaylist 
   TABLE DATA           U   COPY public.tblplaylist (playlistname, creationdate, userid, playlistid) FROM stdin;
    public          postgres    false    219   8G       �          0    24859    tblpremiummembership 
   TABLE DATA           J   COPY public.tblpremiummembership (startdate, enddate, userid) FROM stdin;
    public          postgres    false    220   H       �          0    24862    tblsearchhistory 
   TABLE DATA           J   COPY public.tblsearchhistory (searchname, searchdate, userid) FROM stdin;
    public          postgres    false    221   yH       �          0    24866    tblsessionhistory 
   TABLE DATA           Q   COPY public.tblsessionhistory (sessiondate, operationstatus, userid) FROM stdin;
    public          postgres    false    222   HI       �          0    24870    tblsong 
   TABLE DATA           ]   COPY public.tblsong (songname, singer, songtype, restcount, songid, releaseyear) FROM stdin;
    public          postgres    false    223   �I       �          0    24873    tbluser 
   TABLE DATA           R   COPY public.tbluser (username, password, email, creationdate, userid) FROM stdin;
    public          postgres    false    224   �J                  0    0    tblcomment_commentid_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.tblcomment_commentid_seq', 30, true);
          public          postgres    false    227                       0    0    tbldevices_deviceid_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.tbldevices_deviceid_seq', 11, true);
          public          postgres    false    228                       0    0    tblplaylist_playlistid_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.tblplaylist_playlistid_seq', 10, true);
          public          postgres    false    226                       0    0    tblsong_songid_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.tblsong_songid_seq', 10, true);
          public          postgres    false    229                       0    0    tbluser_userid_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.tbluser_userid_seq', 10, true);
          public          postgres    false    225            P           2606    24959    tblcomment tblcomment_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_pkey PRIMARY KEY (commentid);
 D   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_pkey;
       public            postgres    false    215            R           2606    24966    tbldevices tbldevices_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.tbldevices
    ADD CONSTRAINT tbldevices_pkey PRIMARY KEY (deviceid);
 D   ALTER TABLE ONLY public.tbldevices DROP CONSTRAINT tbldevices_pkey;
       public            postgres    false    216            T           2606    24952    tblplaylist tblplaylist_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.tblplaylist
    ADD CONSTRAINT tblplaylist_pkey PRIMARY KEY (playlistid);
 F   ALTER TABLE ONLY public.tblplaylist DROP CONSTRAINT tblplaylist_pkey;
       public            postgres    false    219            V           2606    24973    tblsong tblsong_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tblsong
    ADD CONSTRAINT tblsong_pkey PRIMARY KEY (songid);
 >   ALTER TABLE ONLY public.tblsong DROP CONSTRAINT tblsong_pkey;
       public            postgres    false    223            X           2606    24890    tbluser tbluser_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tbluser
    ADD CONSTRAINT tbluser_pkey PRIMARY KEY (userid);
 >   ALTER TABLE ONLY public.tbluser DROP CONSTRAINT tbluser_pkey;
       public            postgres    false    224            Y           2606    25038 !   tblcomment tblcomment_songid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_songid_fkey FOREIGN KEY (songid) REFERENCES public.tblsong(songid) NOT VALID;
 K   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_songid_fkey;
       public          postgres    false    215    223    4694            Z           2606    25010 !   tblcomment tblcomment_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 K   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_userid_fkey;
       public          postgres    false    224    4696    215            [           2606    25072 !   tbldevices tbldevices_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tbldevices
    ADD CONSTRAINT tbldevices_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 K   ALTER TABLE ONLY public.tbldevices DROP CONSTRAINT tbldevices_userid_fkey;
       public          postgres    false    4696    224    216            \           2606    25062 -   tblfavouritesong tblfavouritesong_songid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfavouritesong
    ADD CONSTRAINT tblfavouritesong_songid_fkey FOREIGN KEY (songid) REFERENCES public.tblsong(songid) NOT VALID;
 W   ALTER TABLE ONLY public.tblfavouritesong DROP CONSTRAINT tblfavouritesong_songid_fkey;
       public          postgres    false    217    223    4694            ]           2606    25067 -   tblfavouritesong tblfavouritesong_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfavouritesong
    ADD CONSTRAINT tblfavouritesong_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 W   ALTER TABLE ONLY public.tblfavouritesong DROP CONSTRAINT tblfavouritesong_userid_fkey;
       public          postgres    false    224    4696    217            ^           2606    25082 #   tblplaylist tblplaylist_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblplaylist
    ADD CONSTRAINT tblplaylist_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 M   ALTER TABLE ONLY public.tblplaylist DROP CONSTRAINT tblplaylist_userid_fkey;
       public          postgres    false    224    219    4696            _           2606    25087 5   tblpremiummembership tblpremiummembership_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblpremiummembership
    ADD CONSTRAINT tblpremiummembership_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 _   ALTER TABLE ONLY public.tblpremiummembership DROP CONSTRAINT tblpremiummembership_userid_fkey;
       public          postgres    false    224    220    4696            `           2606    25096 -   tblsearchhistory tblsearchhistory_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblsearchhistory
    ADD CONSTRAINT tblsearchhistory_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 W   ALTER TABLE ONLY public.tblsearchhistory DROP CONSTRAINT tblsearchhistory_userid_fkey;
       public          postgres    false    224    221    4696            a           2606    25101 /   tblsessionhistory tblsessionhistory_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblsessionhistory
    ADD CONSTRAINT tblsessionhistory_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 Y   ALTER TABLE ONLY public.tblsessionhistory DROP CONSTRAINT tblsessionhistory_userid_fkey;
       public          postgres    false    224    4696    222            �   �   x�M��N1E�;_�|@�z�]BEBT�4�3!{ٛE��,
���4�H��qHbf����W��+��]�51���E�|uY���1��j�9+*��結���H~8(Y$D��P���1��kr6D��R��� ۅU}�P=ZpG��bܽ�1�bv��Sh�=��O�+�5x������h�/��x�m��d���ɋ�I���d�@54�>����W�      �   �   x�eϿ
�0���)�J����
B�..Q[l����������w�q{wi;���Z�x!�BiNwf�ni�C���f��>�<� ��\:�!M8cHpM�c�"Jg���1�)g��\5�y�3�7ƶ�}��O�c�䟅'�M�
�
,�(V�[�D��<�o�%gJ��YuCf��o\q*	J�y��o(�Z�      �   L   x���;�0�Y�>�q~\�G��B��N��j����fG����2�Ü����27�y�y>f�Pa
ꧯ�!y`�1�      �   \   x��α� C�Zڅ<ۀ1�d�9B��:�5�RL�ѢFCMVV�dcCOvvx�����H399��ڄK�V�/�R����C������H>�aJ�      �   �   x�M��j�0�ϳO�/�b��g�mZ�z�eWT�������@!��}��ꕏ��̓����2U�|�+���I�~��������)��_�9��n?MBK(�`�|��W�IX�%�̣5�;	��Z�BE�{̓,qem�A���%q���[M��h�P�/s\n�dL`�-�4�����k��:�&ފe�MH���l;�x �?MOl      �   V   x�E�A�0D�5�ES�x�����/~q��!׺����ҋ^2�÷�=�!I��)��a�{�rt˿-z�Snz�K��9U��*7      �   �   x��A�0D������
�K�5!!,\���kkhY���b<��y3��4N=Y�{�@$"]$|�p�ݛu��g9����N �u��Hm�`�� œ�kbE"�5��ސ
��Z�������!��HEiX%}��IѬgk,]oC7|Ƿ����V���,$�bE!�6<�5Cx������\���n]��      �   a   x�U�=
�0�ṹ�Ҥ���.R+�J��ׇ�>�����g�m�{v�@��l���eH��։�^<�FK����$Vt�?'�m���
 /�8�      �   6  x�m��n�0���S����^��*��������U���[�v������v&�Y�V�:)���3[�JQ�V
4�t6}P:�h_u�i���)*��T�N,�Hz� �y<�W��s����vC�X��V;Ի �(G<H�wsG?�� 2	���ŞLw�+z��g ι�wn[ǹ�*��:���Į��x��7�b���|�빂�o�,�4�k��+����N�2������r�V0����z�X\���u5n�X<�f]oë���(Ho\��|`�+�
��1c�MCذ�4�o�cE�.>�w      �     x�u�K�� ��}�n��g�]2"���ᑁ���~��-�O�e�0��K������Ŏ�Sn�$�࠾���R��*��'��Y'ۮ�L���ը�In�k��Q\���������!r����la'�T�Z$甌a�g%Pè��z��⣥�C�^FKg���M4FZ�y�������L���H�����q^`̥����`����>#-�V�ZJo�y%�ɬ�QO'�z�`-�wtf�Y9İy����⟸��@�>Z�z     