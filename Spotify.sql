PGDMP  :    (                {         	   SpotifyDB    16.0    16.0 &    *           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            +           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ,           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            -           1262    18396 	   SpotifyDB    DATABASE     �   CREATE DATABASE "SpotifyDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United Kingdom.1252';
    DROP DATABASE "SpotifyDB";
                postgres    false            �            1259    18488 
   tblcomment    TABLE     �   CREATE TABLE public.tblcomment (
    commentid integer NOT NULL,
    userid integer,
    songid integer,
    commenttext character varying(100),
    commentdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
    DROP TABLE public.tblcomment;
       public         heap    postgres    false            �            1259    18530 
   tbldevices    TABLE     �   CREATE TABLE public.tbldevices (
    userid integer,
    deviceid integer NOT NULL,
    devicename character varying(100),
    linkdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    lastplayeddate timestamp without time zone
);
    DROP TABLE public.tbldevices;
       public         heap    postgres    false            �            1259    18468    tblfavouritesong    TABLE     �   CREATE TABLE public.tblfavouritesong (
    userid integer,
    songid integer,
    likedate timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
 $   DROP TABLE public.tblfavouritesong;
       public         heap    postgres    false            �            1259    18482    tblfolloweduser    TABLE     �   CREATE TABLE public.tblfolloweduser (
    followinguser integer,
    followeduser integer NOT NULL,
    followstartdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
 #   DROP TABLE public.tblfolloweduser;
       public         heap    postgres    false            �            1259    18450    tblplaylist    TABLE     �   CREATE TABLE public.tblplaylist (
    playlistid integer NOT NULL,
    playlistname character varying(50),
    createdbyuserid integer,
    creationdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
    DROP TABLE public.tblplaylist;
       public         heap    postgres    false            �            1259    18522    tblpremiummembership    TABLE     g   CREATE TABLE public.tblpremiummembership (
    userid integer,
    startdate date,
    enddate date
);
 (   DROP TABLE public.tblpremiummembership;
       public         heap    postgres    false            �            1259    18513    tblsearchhistory    TABLE     �   CREATE TABLE public.tblsearchhistory (
    userid integer,
    searchname character varying(100),
    searchdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
 $   DROP TABLE public.tblsearchhistory;
       public         heap    postgres    false            �            1259    18504    tblsessionhistory    TABLE     �   CREATE TABLE public.tblsessionhistory (
    userid integer,
    sessiondate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    operationstatus character varying(100)
);
 %   DROP TABLE public.tblsessionhistory;
       public         heap    postgres    false            �            1259    18445    tblsong    TABLE     �   CREATE TABLE public.tblsong (
    songid integer NOT NULL,
    songname character varying(50),
    singer character varying(50),
    releaseyear integer,
    songtype character varying(100),
    restcount integer
);
    DROP TABLE public.tblsong;
       public         heap    postgres    false            �            1259    18434    tbluser    TABLE       CREATE TABLE public.tbluser (
    userid integer NOT NULL,
    username character varying(50),
    password character varying(50),
    email character varying(100),
    creationdate timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    profileimage character varying(100)
);
    DROP TABLE public.tbluser;
       public         heap    postgres    false            #          0    18488 
   tblcomment 
   TABLE DATA           Y   COPY public.tblcomment (commentid, userid, songid, commenttext, commentdate) FROM stdin;
    public          postgres    false    220   W/       '          0    18530 
   tbldevices 
   TABLE DATA           \   COPY public.tbldevices (userid, deviceid, devicename, linkdate, lastplayeddate) FROM stdin;
    public          postgres    false    224   t/       !          0    18468    tblfavouritesong 
   TABLE DATA           D   COPY public.tblfavouritesong (userid, songid, likedate) FROM stdin;
    public          postgres    false    218   �/       "          0    18482    tblfolloweduser 
   TABLE DATA           W   COPY public.tblfolloweduser (followinguser, followeduser, followstartdate) FROM stdin;
    public          postgres    false    219   �/                  0    18450    tblplaylist 
   TABLE DATA           ^   COPY public.tblplaylist (playlistid, playlistname, createdbyuserid, creationdate) FROM stdin;
    public          postgres    false    217   �/       &          0    18522    tblpremiummembership 
   TABLE DATA           J   COPY public.tblpremiummembership (userid, startdate, enddate) FROM stdin;
    public          postgres    false    223   �/       %          0    18513    tblsearchhistory 
   TABLE DATA           J   COPY public.tblsearchhistory (userid, searchname, searchdate) FROM stdin;
    public          postgres    false    222   0       $          0    18504    tblsessionhistory 
   TABLE DATA           Q   COPY public.tblsessionhistory (userid, sessiondate, operationstatus) FROM stdin;
    public          postgres    false    221   "0                 0    18445    tblsong 
   TABLE DATA           ]   COPY public.tblsong (songid, songname, singer, releaseyear, songtype, restcount) FROM stdin;
    public          postgres    false    216   ?0                 0    18434    tbluser 
   TABLE DATA           `   COPY public.tbluser (userid, username, password, email, creationdate, profileimage) FROM stdin;
    public          postgres    false    215   \0       �           2606    18493    tblcomment tblcomment_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_pkey PRIMARY KEY (commentid);
 D   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_pkey;
       public            postgres    false    220            �           2606    18535    tbldevices tbldevices_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.tbldevices
    ADD CONSTRAINT tbldevices_pkey PRIMARY KEY (deviceid);
 D   ALTER TABLE ONLY public.tbldevices DROP CONSTRAINT tbldevices_pkey;
       public            postgres    false    224            �           2606    18487 $   tblfolloweduser tblfolloweduser_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.tblfolloweduser
    ADD CONSTRAINT tblfolloweduser_pkey PRIMARY KEY (followeduser);
 N   ALTER TABLE ONLY public.tblfolloweduser DROP CONSTRAINT tblfolloweduser_pkey;
       public            postgres    false    219            �           2606    18455    tblplaylist tblplaylist_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.tblplaylist
    ADD CONSTRAINT tblplaylist_pkey PRIMARY KEY (playlistid);
 F   ALTER TABLE ONLY public.tblplaylist DROP CONSTRAINT tblplaylist_pkey;
       public            postgres    false    217            ~           2606    18449    tblsong tblsong_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tblsong
    ADD CONSTRAINT tblsong_pkey PRIMARY KEY (songid);
 >   ALTER TABLE ONLY public.tblsong DROP CONSTRAINT tblsong_pkey;
       public            postgres    false    216            |           2606    18439    tbluser tbluser_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tbluser
    ADD CONSTRAINT tbluser_pkey PRIMARY KEY (userid);
 >   ALTER TABLE ONLY public.tbluser DROP CONSTRAINT tbluser_pkey;
       public            postgres    false    215            �           2606    18494 !   tblcomment tblcomment_songid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_songid_fkey FOREIGN KEY (songid) REFERENCES public.tblsong(songid);
 K   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_songid_fkey;
       public          postgres    false    4734    220    216            �           2606    18499 !   tblcomment tblcomment_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblcomment
    ADD CONSTRAINT tblcomment_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid);
 K   ALTER TABLE ONLY public.tblcomment DROP CONSTRAINT tblcomment_userid_fkey;
       public          postgres    false    4732    220    215            �           2606    18536 !   tbldevices tbldevices_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tbldevices
    ADD CONSTRAINT tbldevices_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid);
 K   ALTER TABLE ONLY public.tbldevices DROP CONSTRAINT tbldevices_userid_fkey;
       public          postgres    false    4732    215    224            �           2606    18477 -   tblfavouritesong tblfavouritesong_songid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfavouritesong
    ADD CONSTRAINT tblfavouritesong_songid_fkey FOREIGN KEY (songid) REFERENCES public.tblsong(songid);
 W   ALTER TABLE ONLY public.tblfavouritesong DROP CONSTRAINT tblfavouritesong_songid_fkey;
       public          postgres    false    4734    216    218            �           2606    18472 -   tblfavouritesong tblfavouritesong_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfavouritesong
    ADD CONSTRAINT tblfavouritesong_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid);
 W   ALTER TABLE ONLY public.tblfavouritesong DROP CONSTRAINT tblfavouritesong_userid_fkey;
       public          postgres    false    4732    215    218            �           2606    18525 5   tblpremiummembership tblpremiummembership_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblpremiummembership
    ADD CONSTRAINT tblpremiummembership_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid);
 _   ALTER TABLE ONLY public.tblpremiummembership DROP CONSTRAINT tblpremiummembership_userid_fkey;
       public          postgres    false    223    4732    215            �           2606    18517 -   tblsearchhistory tblsearchhistory_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblsearchhistory
    ADD CONSTRAINT tblsearchhistory_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid);
 W   ALTER TABLE ONLY public.tblsearchhistory DROP CONSTRAINT tblsearchhistory_userid_fkey;
       public          postgres    false    215    4732    222            �           2606    18508 /   tblsessionhistory tblsessionhistory_userid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblsessionhistory
    ADD CONSTRAINT tblsessionhistory_userid_fkey FOREIGN KEY (userid) REFERENCES public.tbluser(userid);
 Y   ALTER TABLE ONLY public.tblsessionhistory DROP CONSTRAINT tblsessionhistory_userid_fkey;
       public          postgres    false    4732    221    215            #      x������ � �      '      x������ � �      !      x������ � �      "      x������ � �             x������ � �      &      x������ � �      %      x������ � �      $      x������ � �            x������ � �            x������ � �     