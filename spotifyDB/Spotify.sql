PGDMP      #                {            spotify    16.0    16.0 -    0           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            1           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            2           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            3           1262    19035    spotify    DATABASE     �   CREATE DATABASE spotify WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United Kingdom.1252';
    DROP DATABASE spotify;
                postgres    false            �            1259    19036 
   tblcomment    TABLE     �   CREATE TABLE public.tblcomment (
    commentid integer NOT NULL,
    songid integer,
    commenttext character varying(100),
    commentdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    userid integer
);
    DROP TABLE public.tblcomment;
       public         heap    postgres    false            �            1259    19040 
   tbldevices    TABLE     �   CREATE TABLE public.tbldevices (
    deviceid integer NOT NULL,
    devicename character varying(100),
    linkdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    lastplayeddate timestamp without time zone,
    userid integer
);
    DROP TABLE public.tbldevices;
       public         heap    postgres    false            �            1259    19044    tblfavouritesong    TABLE     �   CREATE TABLE public.tblfavouritesong (
    songid integer,
    likedate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    userid integer
);
 $   DROP TABLE public.tblfavouritesong;
       public         heap    postgres    false            �            1259    19048    tblfolloweduser    TABLE     �   CREATE TABLE public.tblfolloweduser (
    followinguser integer,
    followeduser integer NOT NULL,
    followstartdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
 #   DROP TABLE public.tblfolloweduser;
       public         heap    postgres    false            �            1259    19052    tblplaylist    TABLE     �   CREATE TABLE public.tblplaylist (
    playlistid integer NOT NULL,
    playlistname character varying(50),
    createdbyuserid integer,
    creationdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    userid integer
);
    DROP TABLE public.tblplaylist;
       public         heap    postgres    false            �            1259    19056    tblpremiummembership    TABLE     g   CREATE TABLE public.tblpremiummembership (
    startdate date,
    enddate date,
    userid integer
);
 (   DROP TABLE public.tblpremiummembership;
       public         heap    postgres    false            �            1259    19059    tblsearchhistory    TABLE     �   CREATE TABLE public.tblsearchhistory (
    searchname character varying(100),
    searchdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    userid integer
);
 $   DROP TABLE public.tblsearchhistory;
       public         heap    postgres    false            �            1259    19063    tblsessionhistory    TABLE     �   CREATE TABLE public.tblsessionhistory (
    sessiondate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    operationstatus character varying(100),
    userid integer
);
 %   DROP TABLE public.tblsessionhistory;
       public         heap    postgres    false            �            1259    19067    tblsong    TABLE     �   CREATE TABLE public.tblsong (
    songid integer NOT NULL,
    songname character varying(50),
    singer character varying(50),
    releaseyear integer,
    songtype character varying(100),
    restcount integer
);
    DROP TABLE public.tblsong;
       public         heap    postgres    false            �            1259    19070    tbluser    TABLE     �   CREATE TABLE public.tbluser (
    username character varying(50),
    password character varying(50),
    email character varying(100),
    creationdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    userid bigint NOT NULL
);
    DROP TABLE public.tbluser;
       public         heap    postgres    false            �            1259    19074    tbluser_userid_seq    SEQUENCE     {   CREATE SEQUENCE public.tbluser_userid_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.tbluser_userid_seq;
       public          postgres    false    224            4           0    0    tbluser_userid_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.tbluser_userid_seq OWNED BY public.tbluser.userid;
          public          postgres    false    225            |           2604    19075    tbluser userid    DEFAULT     p   ALTER TABLE ONLY public.tbluser ALTER COLUMN userid SET DEFAULT nextval('public.tbluser_userid_seq'::regclass);
 =   ALTER TABLE public.tbluser ALTER COLUMN userid DROP DEFAULT;
       public          postgres    false    225    224            #          0    19036 
   tblcomment 
   TABLE DATA           Y   COPY public.tblcomment (commentid, songid, commenttext, commentdate, userid) FROM stdin;
    public          postgres    false    215   �8       $          0    19040 
   tbldevices 
   TABLE DATA           \   COPY public.tbldevices (deviceid, devicename, linkdate, lastplayeddate, userid) FROM stdin;
    public          postgres    false    216   �8       %          0    19044    tblfavouritesong 
   TABLE DATA           D   COPY public.tblfavouritesong (songid, likedate, userid) FROM stdin;
    public          postgres    false    217   9       &          0    19048    tblfolloweduser 
   TABLE DATA           W   COPY public.tblfolloweduser (followinguser, followeduser, followstartdate) FROM stdin;
    public          postgres    false    218   29       '          0    19052    tblplaylist 
   TABLE DATA           f   COPY public.tblplaylist (playlistid, playlistname, createdbyuserid, creationdate, userid) FROM stdin;
    public          postgres    false    219   O9       (          0    19056    tblpremiummembership 
   TABLE DATA           J   COPY public.tblpremiummembership (startdate, enddate, userid) FROM stdin;
    public          postgres    false    220   l9       )          0    19059    tblsearchhistory 
   TABLE DATA           J   COPY public.tblsearchhistory (searchname, searchdate, userid) FROM stdin;
    public          postgres    false    221   �9       *          0    19063    tblsessionhistory 
   TABLE DATA           Q   COPY public.tblsessionhistory (sessiondate, operationstatus, userid) FROM stdin;
    public          postgres    false    222   �9       +          0    19067    tblsong 
   TABLE DATA           ]   COPY public.tblsong (songid, songname, singer, releaseyear, songtype, restcount) FROM stdin;
    public          postgres    false    223   �9       ,          0    19070    tbluser 
   TABLE DATA           R   COPY public.tbluser (username, password, email, creationdate, userid) FROM stdin;
    public          postgres    false    224   �9       5           0    0    tbluser_userid_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.tbluser_userid_seq', 4, true);
          public          postgres    false    225            ~           2606    19077    tblcomment tblcomment_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_pkey PRIMARY KEY (commentid);
 D   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_pkey;
       public            postgres    false    215            �           2606    19079    tbldevices tbldevices_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.tbldevices
    ADD CONSTRAINT tbldevices_pkey PRIMARY KEY (deviceid);
 D   ALTER TABLE ONLY public.tbldevices DROP CONSTRAINT tbldevices_pkey;
       public            postgres    false    216            �           2606    19081 $   tblfolloweduser tblfolloweduser_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.tblfolloweduser
    ADD CONSTRAINT tblfolloweduser_pkey PRIMARY KEY (followeduser);
 N   ALTER TABLE ONLY public.tblfolloweduser DROP CONSTRAINT tblfolloweduser_pkey;
       public            postgres    false    218            �           2606    19083    tblplaylist tblplaylist_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.tblplaylist
    ADD CONSTRAINT tblplaylist_pkey PRIMARY KEY (playlistid);
 F   ALTER TABLE ONLY public.tblplaylist DROP CONSTRAINT tblplaylist_pkey;
       public            postgres    false    219            �           2606    19085    tblsong tblsong_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tblsong
    ADD CONSTRAINT tblsong_pkey PRIMARY KEY (songid);
 >   ALTER TABLE ONLY public.tblsong DROP CONSTRAINT tblsong_pkey;
       public            postgres    false    223            �           2606    19087    tbluser tbluser_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tbluser
    ADD CONSTRAINT tbluser_pkey PRIMARY KEY (userid);
 >   ALTER TABLE ONLY public.tbluser DROP CONSTRAINT tbluser_pkey;
       public            postgres    false    224            �           2606    19088 !   tblcomment tblcomment_songid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_songid_fkey FOREIGN KEY (songid) REFERENCES public.tblsong(songid);
 K   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_songid_fkey;
       public          postgres    false    4742    215    223            �           2606    19191 !   tblcomment tblcomment_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 K   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_userid_fkey;
       public          postgres    false    224    215    4744            �           2606    19200 !   tbldevices tbldevices_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tbldevices
    ADD CONSTRAINT tbldevices_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 K   ALTER TABLE ONLY public.tbldevices DROP CONSTRAINT tbldevices_userid_fkey;
       public          postgres    false    4744    216    224            �           2606    19093 -   tblfavouritesong tblfavouritesong_songid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfavouritesong
    ADD CONSTRAINT tblfavouritesong_songid_fkey FOREIGN KEY (songid) REFERENCES public.tblsong(songid);
 W   ALTER TABLE ONLY public.tblfavouritesong DROP CONSTRAINT tblfavouritesong_songid_fkey;
       public          postgres    false    223    217    4742            �           2606    19209 -   tblfavouritesong tblfavouritesong_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfavouritesong
    ADD CONSTRAINT tblfavouritesong_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 W   ALTER TABLE ONLY public.tblfavouritesong DROP CONSTRAINT tblfavouritesong_userid_fkey;
       public          postgres    false    224    217    4744            �           2606    19153 1   tblfolloweduser tblfolloweduser_followeduser_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfolloweduser
    ADD CONSTRAINT tblfolloweduser_followeduser_fkey FOREIGN KEY (followeduser) REFERENCES public.tbluser(userid) NOT VALID;
 [   ALTER TABLE ONLY public.tblfolloweduser DROP CONSTRAINT tblfolloweduser_followeduser_fkey;
       public          postgres    false    4744    218    224            �           2606    19148 2   tblfolloweduser tblfolloweduser_followinguser_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfolloweduser
    ADD CONSTRAINT tblfolloweduser_followinguser_fkey FOREIGN KEY (followinguser) REFERENCES public.tbluser(userid) NOT VALID;
 \   ALTER TABLE ONLY public.tblfolloweduser DROP CONSTRAINT tblfolloweduser_followinguser_fkey;
       public          postgres    false    224    218    4744            �           2606    19158 #   tblplaylist tblplaylist_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblplaylist
    ADD CONSTRAINT tblplaylist_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 M   ALTER TABLE ONLY public.tblplaylist DROP CONSTRAINT tblplaylist_userid_fkey;
       public          postgres    false    219    224    4744            �           2606    19167 5   tblpremiummembership tblpremiummembership_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblpremiummembership
    ADD CONSTRAINT tblpremiummembership_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 _   ALTER TABLE ONLY public.tblpremiummembership DROP CONSTRAINT tblpremiummembership_userid_fkey;
       public          postgres    false    4744    220    224            �           2606    19175 -   tblsearchhistory tblsearchhistory_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblsearchhistory
    ADD CONSTRAINT tblsearchhistory_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 W   ALTER TABLE ONLY public.tblsearchhistory DROP CONSTRAINT tblsearchhistory_userid_fkey;
       public          postgres    false    224    221    4744            �           2606    19183 /   tblsessionhistory tblsessionhistory_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblsessionhistory
    ADD CONSTRAINT tblsessionhistory_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid) NOT VALID;
 Y   ALTER TABLE ONLY public.tblsessionhistory DROP CONSTRAINT tblsessionhistory_userid_fkey;
       public          postgres    false    4744    222    224            #      x������ � �      $      x������ � �      %      x������ � �      &      x������ � �      '      x������ � �      (      x������ � �      )      x������ � �      *      x������ � �      +      x������ � �      ,   �   x�=�=�0Fg��@"�����AXR*���/�������^��X!���St���kH)�V?O��8��ԳNL��I+Zm�S�ؙ��a\�d'4Ü%�bߺ�>�n�jm�p�����K�\(���%2D�D�"E,     